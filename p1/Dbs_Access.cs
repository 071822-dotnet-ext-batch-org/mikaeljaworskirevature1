using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p1
{
    public class Dbs_Access
    {
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
        public Employees  CreateEmployee(Employees e)
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

        //TODO create two methods for password creation; one for managers, one for employees
        //      methods must specify the variables of insert so that one of the fk's are left null
        public Managers  CreateEmployeePassword(Passwords p)
        {
            using (SqlCommand command = new SqlCommand($"INSERT INTO cl.Passwords VALUES(@Pw_Id, @EId, @M_Id)", stash))
            {
                command.Parameters.AddWithValue("@Pw_Id", p.PassId);
                command.Parameters.AddWithValue("@EId", p.FkEmp);
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
        } //EoM

        //TODO create a ticket creation method. tickets can only be made by employees
        //      make the default ticket status "pending". employees can not change the ticket type status.
        //TODO CREATE a change ticket type query that creates a status for the existing tickets. 
        //      make sure it doesnt create new tickets. only checks for existing ones and then changes the status.    

    } //EoC
} //EoN