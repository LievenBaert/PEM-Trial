namespace DMC {
    
    
    // Arcelor generated code (2007-12-04 17:06:39)
    public class AUTUSR {
        
        public static System.Data.SqlClient.SqlParameter ID_TCH_USR {
            get {
                System.Data.SqlClient.SqlParameter pm;
                pm = new System.Data.SqlClient.SqlParameter("@ID_TCH_USR", System.Data.SqlDbType.Char, 13, "ID_TCH_USR");
                return pm;
            }
        }
        
        public static System.Data.SqlClient.SqlParameter NM {
            get {
                System.Data.SqlClient.SqlParameter pm;
                pm = new System.Data.SqlClient.SqlParameter("@NM", System.Data.SqlDbType.Char, 32, "NM");
                return pm;
            }
        }
        
        public static System.Data.SqlClient.SqlParameter SCF {
            get {
                System.Data.SqlClient.SqlParameter pm;
                pm = new System.Data.SqlClient.SqlParameter("@SCF", System.Data.SqlDbType.NChar, 254, "SCF");
                return pm;
            }
        }
        
        public static System.Data.SqlClient.SqlParameter GetID_TCH_USR(string parameterName) {
            System.Data.SqlClient.SqlParameter pm;
            pm = new System.Data.SqlClient.SqlParameter(string.Format("@{0}", parameterName), System.Data.SqlDbType.Char, 13, "ID_TCH_USR");
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetID_TCH_USR(System.Data.DataRowVersion version) {
            System.Data.SqlClient.SqlParameter pm;
            if ((version == System.Data.DataRowVersion.Original)) {
                pm = new System.Data.SqlClient.SqlParameter("@Original_ID_TCH_USR", System.Data.SqlDbType.Char, 13, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID_TCH_USR", version, null);
            }
            else {
                pm = new System.Data.SqlClient.SqlParameter("@ID_TCH_USR", System.Data.SqlDbType.Char, 13, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID_TCH_USR", version, null);
            }
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetID_TCH_USR(string parameterName, System.Data.DataRowVersion version) {
            System.Data.SqlClient.SqlParameter pm;
            if ((version == System.Data.DataRowVersion.Original)) {
                pm = new System.Data.SqlClient.SqlParameter(string.Format("@Original_{0}", parameterName), System.Data.SqlDbType.Char, 13, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID_TCH_USR", version, null);
            }
            else {
                pm = new System.Data.SqlClient.SqlParameter(string.Format("@{0}", parameterName), System.Data.SqlDbType.Char, 13, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID_TCH_USR", version, null);
            }
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetNM(string parameterName) {
            System.Data.SqlClient.SqlParameter pm;
            pm = new System.Data.SqlClient.SqlParameter(string.Format("@{0}", parameterName), System.Data.SqlDbType.Char, 32, "NM");
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetNM(System.Data.DataRowVersion version) {
            System.Data.SqlClient.SqlParameter pm;
            if ((version == System.Data.DataRowVersion.Original)) {
                pm = new System.Data.SqlClient.SqlParameter("@Original_NM", System.Data.SqlDbType.Char, 32, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NM", version, null);
            }
            else {
                pm = new System.Data.SqlClient.SqlParameter("@NM", System.Data.SqlDbType.Char, 32, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NM", version, null);
            }
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetNM(string parameterName, System.Data.DataRowVersion version) {
            System.Data.SqlClient.SqlParameter pm;
            if ((version == System.Data.DataRowVersion.Original)) {
                pm = new System.Data.SqlClient.SqlParameter(string.Format("@Original_{0}", parameterName), System.Data.SqlDbType.Char, 32, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NM", version, null);
            }
            else {
                pm = new System.Data.SqlClient.SqlParameter(string.Format("@{0}", parameterName), System.Data.SqlDbType.Char, 32, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NM", version, null);
            }
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetSCF(string parameterName) {
            System.Data.SqlClient.SqlParameter pm;
            pm = new System.Data.SqlClient.SqlParameter(string.Format("@{0}", parameterName), System.Data.SqlDbType.NChar, 254, "SCF");
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetSCF(System.Data.DataRowVersion version) {
            System.Data.SqlClient.SqlParameter pm;
            if ((version == System.Data.DataRowVersion.Original)) {
                pm = new System.Data.SqlClient.SqlParameter("@Original_SCF", System.Data.SqlDbType.NChar, 254, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SCF", version, null);
            }
            else {
                pm = new System.Data.SqlClient.SqlParameter("@SCF", System.Data.SqlDbType.NChar, 254, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SCF", version, null);
            }
            return pm;
        }
        
        public static System.Data.SqlClient.SqlParameter GetSCF(string parameterName, System.Data.DataRowVersion version) {
            System.Data.SqlClient.SqlParameter pm;
            if ((version == System.Data.DataRowVersion.Original)) {
                pm = new System.Data.SqlClient.SqlParameter(string.Format("@Original_{0}", parameterName), System.Data.SqlDbType.NChar, 254, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SCF", version, null);
            }
            else {
                pm = new System.Data.SqlClient.SqlParameter(string.Format("@{0}", parameterName), System.Data.SqlDbType.NChar, 254, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SCF", version, null);
            }
            return pm;
        }
    }
}
