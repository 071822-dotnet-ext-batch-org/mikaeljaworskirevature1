using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RepoLayer
{
    public class Dbs_Access
    {

        //TODO edit the code to call the accounts class under models so the accounts on the db can be updated accordingly
        //reference mark adodotnetaccess class
        private static readonly SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        
        //method to find an existing employee account
        public bool ExistingEmployee(Guid employeeid)
        {
            using (SqlCommand command = new SqlCommand("SELECT Top 1 E_UserId FROM Employees WHERE E_UserId = @x", stash))
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
        //method to create a new employee account
        public Employees CreateEmployee(Employees e)
        {
            using (SqlCommand command = new SqlCommand($"INSERT INTO cl.Employees VALUES(@userid, @fname, @lname, @address, @aptsuite, @city, @state, @country, @dob)", stash))
            {
                command.Parameters.AddWithValue("@userid", e.UserId);
                command.Parameters.AddWithValue("@fname", e.Fname);
                command.Parameters.AddWithValue("@lname", e.Lname);
                command.Parameters.AddWithValue("@address", e.Address);
                command.Parameters.AddWithValue("@aptsuite", e.AptSuite);
                command.Parameters.AddWithValue("@city", e.City);
                command.Parameters.AddWithValue("@state", e.State);
                command.Parameters.AddWithValue("@country", e.Country);
                command.Parameters.AddWithValue("@dob", e.Dob);
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
        //method to find an existing manager account
        public bool ExistingManager(Guid managerid)
        {
            using (SqlCommand command = new SqlCommand("SELECT Top 1 M_UserId FROM Managers WHERE M_UserId = @y", stash))
            {
                command.Parameters.AddWithValue("@y", managerid);
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
        //method to create a new manager account
        public Managers  CreateManager(Managers m)
        {
            using (SqlCommand command = new SqlCommand($"INSERT INTO cl.Managers VALUES(@userid, @fname, @lname, @address, @aptsuite, @city, @state, @country, @staffid, @dob)", stash))
            {
                command.Parameters.AddWithValue("@userid", m.UserId);
                command.Parameters.AddWithValue("@fname", m.Fname);
                command.Parameters.AddWithValue("@lname", m.Lname);
                command.Parameters.AddWithValue("@address", m.Address);
                command.Parameters.AddWithValue("@aptsuite", m.AptSuite);
                command.Parameters.AddWithValue("@city", m.City);
                command.Parameters.AddWithValue("@state", m.State);
                command.Parameters.AddWithValue("@country", m.Country);
                command.Parameters.AddWithValue("@staffid", m.StaffId);
                command.Parameters.AddWithValue("@dob", m.Dob);
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
        public bool ExistingPassword(Guid passwordid)
        {
            using (SqlCommand command = new SqlCommand("SELECT Top 1 Pw_Id FROM Passwords WHERE Pw_Id = @z", stash))
            {
                command.Parameters.AddWithValue("@z", passwordid);
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
        //method to create a new manager or employee password

        //creates employee pw with custom values to ensure manager id returns null
        public Managers  CreateEmployeePassword(Passwords p)
        {
            using (SqlCommand command = new SqlCommand($"INSERT (Pw_Id, E_Id) INTO cl.Passwords VALUES(@Pw_Id, @EId)", stash))
            {
                command.Parameters.AddWithValue("@Pw_Id", p.PassId);
                command.Parameters.AddWithValue("@EId", p.FkEmp);
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

        //creates manager pw with custome values to ensure employee id returns null
        public Managers  CreateManagerPassword(Passwords p)
        {
            using (SqlCommand command = new SqlCommand($"INSERT (Pw_Id, M_Id) INTO cl.Passwords VALUES(@Pw_Id, @M_Id)", stash))
            {
                command.Parameters.AddWithValue("@Pw_Id", p.PassId);
                command.Parameters.AddWithValue("@M_Id", p.FkMan);
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
        
        //mehtod creates a new ticket and sends it to the db for storage.
        public Tickets CreateTicketQuery(Tickets t)
        {
            using (SqlCommand command = new SqlCommand($"INSERT INTO cl.Passwords VALUES(@ticketid, @tickettype, @ticketdate, @ticketamount, @notes, @m_id, @e_id)", stash))
            {
                command.Parameters.AddWithValue("@ticketId", t.TickedId);
                command.Parameters.AddWithValue("@ticketype", t.TicketType);
                command.Parameters.AddWithValue("@ticketdate", t.TicketDate);
                command.Parameters.AddWithValue("@notes", t.Notes);
                command.Parameters.AddWithValue("@m_id", t.M_Id);
                command.Parameters.AddWithValue("@e_id", t.E_Id);
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
        public bool ExistingTicket(Guid ticketid)
        {
            using (SqlCommand command = new SqlCommand("SELECT Top 1 TicketId Em FROM cl.Tickets WHERE TicketId = @t", stash))
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
        public Tickets TicketStatusApp(Tickets st)
        {
            using (SqlCommand command = new SqlCommand($"UPDATE cl.Tickets SET TicketType = 'Approved' WHERE M_Id = @m", stash))
            {
                command.Parameters.AddWithValue("@m", st.M_Id);
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
        public Tickets TicketStatusDen(Tickets st)
        {
            using (SqlCommand command = new SqlCommand($"UPDATE cl.Tickets SET TicketType = 'Denied' WHERE M_Id = @m", stash))
            {
                command.Parameters.AddWithValue("@m", st.M_Id);
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

    } //EoC
} //EoN