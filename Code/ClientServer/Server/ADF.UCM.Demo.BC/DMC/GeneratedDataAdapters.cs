namespace DMC {
    
    
    // Arcelor generated code (2007-12-04 17:06:39)
    public class UpdateDataAdapters {
        
        public static System.Data.SqlClient.SqlDataAdapter daAUTUSR(System.Data.Common.DataTableMapping tableMapping) {
            System.Data.SqlClient.SqlDataAdapter da;
            da = ADF.Data.SqlClient.SqlHelper.GetSqlDataAdapter("USP_WY_AUTUSR", ADF.Data.DbHelper.ActionEnum.Update);
            ADF.Data.SqlClient.SqlHelper.AddTableMapping(tableMapping, da);
            if (tableMapping.ColumnMappings.Contains("ID_TCH_USR")) {
                ADF.Data.SqlClient.SqlHelper.AddParameter("@ID_TCH_USR", System.Data.SqlDbType.Char, 13, "ID_TCH_USR", System.Data.DataRowVersion.Current, da);
            }
            if (tableMapping.ColumnMappings.Contains("NM")) {
                ADF.Data.SqlClient.SqlHelper.AddParameter("@NM", System.Data.SqlDbType.Char, 32, "NM", System.Data.DataRowVersion.Current, da);
            }
            if (tableMapping.ColumnMappings.Contains("SCF")) {
                ADF.Data.SqlClient.SqlHelper.AddParameter("@SCF", System.Data.SqlDbType.NChar, 254, "SCF", System.Data.DataRowVersion.Current, da);
            }
            if (tableMapping.ColumnMappings.Contains("ID_TCH_USR")) {
                ADF.Data.SqlClient.SqlHelper.AddParameter("@Original_ID_TCH_USR", System.Data.SqlDbType.Char, 13, "ID_TCH_USR", System.Data.DataRowVersion.Original, da);
            }
            return da;
        }
    }
}
