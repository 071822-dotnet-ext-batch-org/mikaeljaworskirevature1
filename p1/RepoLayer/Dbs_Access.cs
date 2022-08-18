using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace RepoLayer
{
    public class Dbs_Access
    {
        //TODO edit the code to call the accounts class under models so the accounts on the db can be updated accordingly
        // ALSO!!! DB has changed so update the code and classes to coincide db changed
        //reference mark adodotnetaccess class
        private static readonly SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        
        //method to find an existing account
        //accounts are now under one table on the tk schema.
        public bool ExistingEmployee(Guid employeeid)
        {
            using (SqlCommand command = new SqlCommand("SELECT Top 1 UserId FROM tk.accounts WHERE UserId = @x", stash))
            {
                command.Parameters.AddWithValue("@x", employeeid);
                stash.Open();
                SqlDataReader ret = command.ExecuteReader();

                if(ret.Read())
                {
                    stash.Close();
                    return true;
                }
                else
                {
                    stash.Close();
                    return false;
                }
            }

        } //EoM
        
        //method to create a new employee account w/ default employee status
        //method utilizes a db procedure to automate process without a local query being written
        public Employees CreateEmployee(Accounts n)
        {
            using (SqlCommand command = new SqlCommand($"tk.Add_Account", stash))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fname", n.Fname);
                command.Parameters.AddWithValue("@lname", n.Lname);
                command.Parameters.AddWithValue("@username", n.Username);
                command.Parameters.AddWithValue("@pw", n.PW);
                command.Parameters.AddWithValue("@userid", n.UserId);
                command.Parameters.AddWithValue("@ismanager", n.IsManager);
                stash.Open();
                int ret = command.ExecuteNonQuery();

                if (ret == 1)
                {
                    stash.Close();
                    return ret;
                }
                else
                {
                    stash.Close();
                    return ret;
                }
            }
        } //EoM
        
        //method to find an existing password associated with a manager or employee account
        public bool ExistingPassword(string password)
        {
            using (SqlCommand command = new SqlCommand("SELECT Top 1 PW FROM tk.accounts WHERE PW = @z", stash))
            {
                command.Parameters.AddWithValue("@z", password);
                stash.Open();
                SqlDataReader ret = command.ExecuteReader();

                if(ret.Read())
                {
                    stash.Close();
                    return true;
                }
                else
                {
                    stash.Close();
                    return false;
                }
            }

        } //EoM

        //method creates a new ticket and sends it to the db for storage.
        public Tickets CreateTicketQuery(Tickets t)
        {
            using (SqlCommand command = new SqlCommand($"tk.Add_Request", stash))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ticketamount", t.TicketAmount);
                command.Parameters.AddWithValue("@ticketstatus", t.TicketStatus);
                command.Parameters.AddWithValue("@notes", t.Notes);
                command.Parameters.AddWithValue("@userfk", t.User_Fk);
                command.Parameters.AddWithValue("@requestid", t.RequestId);
                stash.Open();
                int ret = command.ExecuteNonQuery();
    

                if (ret == 1)
                {
                    stash.Close();
                    return ret;
                }
                else
                {
                    stash.Close();
                    return ret;
                }
            }
        }// EoM
   
        //change ticket type query that creates a status for the existing tickets. 
        //      make sure it doesnt create new tickets. only checks for existing ones and then changes the status.    
        public bool ExistingTicket(Guid requestid)
        {
            using (SqlCommand command = new SqlCommand("SELECT Top 1 RequestId Em FROM tk.tickets WHERE RequestId = @t", stash))
            {
                command.Parameters.AddWithValue("@t", ticketid);
                stash.Open();
                SqlDataReader ret = command.ExecuteReader();

                if(ret.Read())
                {
                    stash.Close();
                    return true;
                }
                else
                {
                    stash.Close();
                    return false;
                }
            }

        }

        // changes the status of the ticket from the default "pending" to "approved"
        // pending is set to int '0'. have to change the int to '1' to set it as approved.
        public Tickets TicketStatusApp(Tickets st)
        {
            using (SqlCommand command = new SqlCommand($"UPDATE tk.tickets SET TicketStatus = 1 WHERE User_Fk = @m", stash))
            {
                command.Parameters.AddWithValue("@m", st.User_Fk);
                stash.Open();
                int ret = command.ExecuteNonQuery();
    

                if (ret == 1)
                {
                    stash.Close();
                    return ret;
                }
                else
                {
                    stash.Close();
                    return ret;
                }
            }
        }


        // changes the status of the ticket from the default "pending" to "denied"
        // pending is set to int '0'. have to change the int to '2' to set it as denied.
        public Tickets TicketStatusDen(Tickets st)
        {
            using (SqlCommand command = new SqlCommand($"UPDATE cl.Tickets SET TicketStatus = 2 WHERE User_Fk = @m", stash))
            {
                command.Parameters.AddWithValue("@m", st.User_Fk);
                stash.Open();
                int ret = command.ExecuteNonQuery();
    

                if (ret == 1)
                {
                    stash.Close();
                    return ret;
                }
                else
                {
                    stash.Close();
                    return ret;
                }
            }
        }

    }
}