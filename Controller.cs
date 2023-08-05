using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDB
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public int InsertPatient(int ID, string Name, string Adress, string mail, int NID, int DRID, int RoomNO, string Tel)
        {
            string query = "INSERT INTO Patients VALUES(" + ID + ",'" + Name + "', '" + Adress + "', '" + mail + "', " + NID + "," + DRID + "," + RoomNO + ", '" + Tel + "' );";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertDoc(int ID, string Name, string Adress, string Tel, string mail, string Dep)
        {
            string query = "INSERT INTO Doctors VALUES(" + ID + ",'" + Name + "', '" + Adress + "', '" + Tel + "', '" + mail + "', '" + Dep + "' );";
            return dbMan.ExecuteNonQuery(query);
        }



        public int InsertDep(string Name, int ID)
        {
            string query = "INSERT INTO Department VALUES('" + Name + "', " + ID + " );";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertNur(int ID, string Tel, string mail, string Adress, string Name)
        {
            string query = "INSERT INTO Nurses VALUES(" + ID + ",'" + Tel + "', '" + mail + "', '" + Adress + "', '" + Name + "' );";
            return dbMan.ExecuteNonQuery(query);
        }


        public int InsertMed(string Name, int ID, int Price, int PatientId)
        {
            string query = "INSERT INTO Medicines VALUES('" + Name + "', " + ID + "," + Price + "," + PatientId + " );";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertRoom(int Price, string type, int Num)
        {
            string query = "INSERT INTO Rooms VALUES(" + Price + ",'" + type + "'," + Num + ");";
            return dbMan.ExecuteNonQuery(query);
        }



        public int UpdateNurse(string Tel, string Email, string Adress, int Id)
        {
            string query = "UPDATE Nurses set NurseTel= " + "'" + Tel + "'," + "NurseEmail= " + "'" + Email + "'," + "NurseAddress=" + "'" + Adress + "'" + "WHERE NurseId = " + Id + "";
            return dbMan.ExecuteNonQuery(query);
        }


        public int UpdateDoctor(string Adress, string Tel, string Email, int Id)
        {
            string query = "UPDATE Nurses set DoctorAddress= " + "'" + Adress + "'," + "DoctorTel= " + "'" + Tel + "'," + "DoctorEMail=" + "'" + Email + "'" + "WHERE DoctorId = " + Id + "";
            return dbMan.ExecuteNonQuery(query);
        }




        public int DeleteDR(int id)
        {
            string query = "DELETE FROM Doctors WHERE DoctorId=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }


        public int DeleteNur(int id)
        {
            string query = "DELETE FROM Nurses WHERE NurseId=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }


        public int DeletePat(int id)
        {
            string query = "DELETE FROM Patients WHERE PatientId=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }



        public DataTable SelectDepName()
        {
            string query = "SELECT DeptName From Department ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDRID()
        {
            string query = "SELECT DoctorId From Doctors ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectNUID()
        {
            string query = "SELECT NurseId From Nurses ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectPID()
        {
            string query = "SELECT PatientId From Patients ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectPatient()
        {
            string query = "SELECT * From Patients ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectMedicine()
        {
            string query = "SELECT * From Medicines ";
            return dbMan.ExecuteReader(query);
        }




        public DataTable SelectDR()
        {
            string query = "SELECT * From Doctors ";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectNurse()
        {
            string query = "SELECT * From Nurses ";
            return dbMan.ExecuteReader(query);
        }



        public DataTable SelectRoom()
        {
            string query = "SELECT * From Rooms ";
            return dbMan.ExecuteReader(query);
        }




        public DataTable SelectRoomNo()
        {
            string query = "SELECT RoomNo From Rooms ";
            return dbMan.ExecuteReader(query);
        }

    }
}
