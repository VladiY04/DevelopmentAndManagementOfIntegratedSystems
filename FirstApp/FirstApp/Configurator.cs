using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

public class Configurator
{
    private DBManipulator manipulator;
    public Configurator()
    {
        this.manipulator = new DBManipulator();
    }

    public void SaveSpecialty(int id, string name)
    {
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "INSERT INTO Speciality (SpecialityID, SpecialityName) VALUES(@SpecialityID, @SpecialityName)";
            SqlParameter param = null;
            param = new SqlParameter("@SpecialityId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            param = new SqlParameter("@SpecialityName", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }
    }
    public void SaveSubject(int id, string name)
    {
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "INSERT INTO Subject (SubjectID, SubjectName) VALUES (@SubjectID, @SubjectName)";
            SqlParameter param = null;
            param = new SqlParameter("@SubjectID", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            param = new SqlParameter("@SubjectName", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }
    }
    public void SaveStudent(int fNumber, int specialtyId, string fName, string mName, string
lName, string address, string phone, string eMail)
    {
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "INSERT INTO Student (FNumber, SpecialityID,FName, MName, LName, Address, Phone, EMail) VALUES(@FNumber, @SpecialtyId,@FName, @MName, @LName, @Address, @Phone, @EMail)";
            SqlParameter param = null;
            param = new SqlParameter("@FNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);
            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = specialtyId;
            command.Parameters.Add(param);
            param = new SqlParameter("@FName", SqlDbType.VarChar);
            param.Value = fName;
            command.Parameters.Add(param);
            param = new SqlParameter("@MName", SqlDbType.VarChar);
            param.Value = mName;
            command.Parameters.Add(param);
            param = new SqlParameter("@LName", SqlDbType.VarChar);
            param.Value = lName;
            command.Parameters.Add(param);
            param = new SqlParameter("@Address", SqlDbType.VarChar);
            param.Value = address;
            command.Parameters.Add(param);
            param = new SqlParameter("@Phone", SqlDbType.VarChar);
            param.Value = phone;
            command.Parameters.Add(param);
            param = new SqlParameter("@EMail", SqlDbType.VarChar);
            param.Value = eMail;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }
    }
    public DataTable LoadSpecialties()
    {
        DataTable result = new DataTable();
        result.Columns.Add("id");
        result.Columns.Add("name");
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT SpecialityID, SpecialityName FROM Speciality ORDER BY SpecialityName ACS";
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SpecialtyID"]);
                    string name = Convert.ToString(reader["SpecialityName"]);
                    DataRow row = result.NewRow();
                    row[0] = id;
                    row[1] = name;
                    result.Rows.Add(row);
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }
        return result;
    }

    public void SaveGrade(int fNumber, int subjectId, int finalGrade)
    {
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "INSERT INTO StudentSubject (FNumber, SubjectID,FinalGrade) VALUES(@FNumber, @SubjectID, @FinalGrade)";
        SqlParameter param = null;
            param = new SqlParameter("@FNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);
            param = new SqlParameter("@SubjectID", SqlDbType.Int);
            param.Value = subjectId;
            command.Parameters.Add(param);
            param = new SqlParameter("@FinalGrade", SqlDbType.Int);
            param.Value = finalGrade;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }

    }
    public DataTable LoadStudents()
    {
        DataTable result = new DataTable();
        result.Columns.Add("fnumber");
        result.Columns.Add("name");
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT FNumber, FName, LName FROM Student ORDER BY FNumber ASC";
        SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int fNumber = Convert.ToInt32(reader["FNumber"]);
                    string fName = Convert.ToString(reader["FName"]);
                    string lName = Convert.ToString(reader["LName"]);
                    DataRow row = result.NewRow();
                    row[0] = fNumber;
                    row[1] = fNumber + " " + fName + " " + lName;
                    result.Rows.Add(row);
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }
        return result;
    }

    public DataTable LoadSubjects()
    {
        DataTable result = new DataTable();
        result.Columns.Add("id");
        result.Columns.Add("name");
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT SubjectID, SubjectName FROM Subject ORDER BY Name ASC";
        SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SubjectID"]);
                    string name = Convert.ToString(reader["SubjectName"]);
                    DataRow row = result.NewRow();
                    row[0] = id;
                    row[1] = name;
                    result.Rows.Add(row);
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }
        return result;
    }

    public void UpdateSpecialty(int originalId, int id, string name)
    {
        SqlConnection connection = this.manipulator.GetConnection();
        try
        {
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "UPDATE Speciality SET SpecialtyId = @SpecialityID,SpecialityName = @SpecialityName WHERE SpecialityID = @OriginalId";
        SqlParameter param = null;
            param = new SqlParameter("@SpecialityID", SqlDbType.Int); param.Value = id;
            command.Parameters.Add(param);
            param = new SqlParameter("@SpecialityName", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);
            param = new SqlParameter("@OriginalId", SqlDbType.Int);
            param.Value = originalId;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            connection.Close();
        }
    }
}

