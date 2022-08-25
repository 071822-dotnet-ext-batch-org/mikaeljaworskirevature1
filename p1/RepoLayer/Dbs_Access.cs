using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace RepoLayer
{
    public class Dbs_Access
    {    
        
        //method to create a new employee account w/ default employee status
        //method utilizes a db procedure to automate process without a local query being written
        //public async Task<Employees> NewUserEmpAsync(Employees n)
        //{
        //    SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //    using (SqlCommand command = new SqlCommand($"tk.Add_Account", stash))
        //    {
        //        command.CommandType = CommandType.StoredProcedure; //wanted to have the procedure generate a fresh guid but will have to refactor that another time.
        //        command.Parameters.AddWithValue("@fname", n.Fname);
        //        command.Parameters.AddWithValue("@lname", n.Lname);
        //        command.Parameters.AddWithValue("@username", n.Username);
        //        command.Parameters.AddWithValue("@pw", n.PW);
        //        command.Parameters.AddWithValue("@userid", n.UserId);
        //        stash.Open();
        //        int ret = await command.ExecuteNonQueryAsync();

        //        if (ret > 1)
        //        {
        //            return n;
        //        }
        //        stash.Close();
        //        return null;
        //    }
        //} //EoM


        public async Task<Managers> NewUserAsync(Managers n)
        {
            SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"tk.Add_Acccount", stash))
            {
                command.CommandType = CommandType.StoredProcedure; //wanted to have the procedure generate a fresh guid but will have to refactor that another time.
                command.Parameters.AddWithValue("@fname", n.Fname);
                command.Parameters.AddWithValue("@lname", n.Lname);
                command.Parameters.AddWithValue("@username", n.Username);
                command.Parameters.AddWithValue("@pw", n.PW);
                command.Parameters.AddWithValue("@userid", n.UserId);
                command.Parameters.AddWithValue("@ismanager", n.IsManager);
                stash.Open();
                int ret = await command.ExecuteNonQueryAsync();

                if (ret > 1)
                {
                    return n;
                }
                stash.Close();
                return null;
            }
        } //EoM
        //method to find an existing password associated with a manager or employee account
        /*
        public async Task<bool> ExistingPasswordAsync(string password)
        {
            SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand("SELECT Top 1 PW FROM tk.accounts WHERE PW = @z", stash))
            {
                command.Parameters.AddWithValue("@z", password);
                stash.Open();
                SqlDataReader ret = await command.ExecuteReaderAsync();

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
        */

        //method to log into an existing account. 
        //accounts are now under one table on the tk schema.
        // account creation will be done locally and then uploaded to the db if no username exists.
        public async Task<Login> GetLoginAsync(Login login)
        {
            SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand("SELECT UserName, PW FROM tk.accounts WHERE UserName = @x AND PW = @y", stash))
            {
                command.Parameters.AddWithValue("@x", login.Username); //allows local input to avoid outside injections with sql
                command.Parameters.AddWithValue("@y", login.Password); //allows local input to avoid outside injections with sql
                stash.Open();
                SqlDataReader ret = await command.ExecuteReaderAsync();
                Login l = null;

                if(ret.Read())
                {
                    l = new Login(ret.GetString(0), ret.GetString(1));
                    return l;
                }
                stash.Close();
                return null;
            }

        } //EoM

        //method to retrieve a manager from the db
        public async Task<bool> GetManagerAsync(Guid userid)
    {
        SqlConnection conn = new SqlConnection("Server=tcp:ilcarmichaelrevature.database.windows.net,1433;Initial Catalog=ProjectOne;Persist Security Info=False;User ID=ilcarmichael;Password=Idontusethisforanythingelse1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        using (SqlCommand cmd = new SqlCommand($"SELECT IsManager FROM tk.accounts WHERE UserId = @id", conn))
        {
            cmd.Parameters.AddWithValue("@id", userid);
            conn.Open();
            SqlDataReader ret = await cmd.ExecuteReaderAsync();
            if (ret.Read() && ret.GetBoolean(0))
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
    }

        //method creates a new ticket and sends it to the db for storage.
        public async Task<Tickets> CreateTicketQueryAsync(Tickets t)
        {
            SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"tk.Add_Request", stash))
            {
                command.CommandType = CommandType.StoredProcedure; //uses a stored procedure to shorten the concat paramater length.
                command.Parameters.AddWithValue("@ticketamount", t.TicketAmount);
                command.Parameters.AddWithValue("@ticketstatus", t.TicketStatus);
                command.Parameters.AddWithValue("@notes", t.Notes);
                command.Parameters.AddWithValue("@user_fk", t.User_Fk);
                command.Parameters.AddWithValue("@requestid", t.RequestId);
                stash.Open();
                int ret = await command.ExecuteNonQueryAsync();
    

                if (ret > 1)
                {
                    return t;
                }
                    stash.Close();
                    return null;
            }
        }// EoM
   
        //ticket method that checks the status for all existing tickets.    
        public async Task<List<Tickets>> GetTicketStatusAsync(int status)
        {
            SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand("SELECT * FROM tk.tickets WHERE TicketStatus = @stat", stash))
            {
                command.Parameters.AddWithValue("@stat", status);
                stash.Open();
                SqlDataReader ret = await command.ExecuteReaderAsync();
                List<Tickets> listtickets = new List<Tickets>();

                while(ret.Read())
                {
                    var t = new Tickets(ret.GetFloat(0), ret.GetInt32(1), ret.GetString(2), ret.GetInt32(3), ret.GetGuid(4));
                    listtickets.Add(t);
                }
                    stash.Close();
                    return listtickets;
            }

        }

        // changes the status of the ticket from the default "pending" to "approved"
        // pending is set to int '0'. have to change the int to '1' to set it as approved.
        public async Task<UpdateDto> TicketStatusAppAsync(Guid RequestId, int Status)
        {
            SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"UPDATE tk.tickets SET TicketStatus = @s WHERE RequestId = @m", stash))
            {
                command.Parameters.AddWithValue("@s", Status); //status returns a specific int that will automatically set it to approval.
                command.Parameters.AddWithValue("@m", RequestId); //status returns a specific int that will automatically set it to approval.
                stash.Open();
                int ret = await command.ExecuteNonQueryAsync();

                if (ret == 1)
                {
                    stash.Close();
                    
                    UpdateDto approved = await this.TicketStatusAppAsync(RequestId);
                    return approved;
                }
                stash.Close();
                return null;
            }
        }

        private Task<UpdateDto> TicketStatusAppAsync(Guid requestId)
        {
            throw new NotImplementedException();
        }


        // changes the status of the ticket from the default "pending" to "denied"
        // pending is set to int '0'. have to change the int to '2' to set it as denied.
        public async Task<Tickets> TicketStatusDenAsync(Tickets st)
        {
            SqlConnection stash = new SqlConnection("Server=tcp:mjrevatureserver.database.windows.net,1433;Initial Catalog=mjaworskiproject1;Persist Security Info=False;User ID=master;Password=REVATURubie$235;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"UPDATE cl.Tickets SET TicketStatus = @s WHERE RequestId = @m", stash))
            {
                command.Parameters.AddWithValue("@s", st.TicketStatus);
                command.Parameters.AddWithValue("@m", st.RequestId);
                stash.Open();
                int ret = await command.ExecuteNonQueryAsync();
    

                if (ret == 1)
                {
                    stash.Close();
                    
                    Tickets denied = await this.TicketStatusDenAsync(st);
                    return denied;
                }
                stash.Close();
                return null;
            }
        }


        public Task<DeniedDto> TicketStatusDenAsync(Guid ticketid, int deniedstatus)
        {
            throw new NotImplementedException();
        }
    }
}