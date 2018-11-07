using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SegmentInserter
{
    class DatabaseAccessor
    {

        public static DataTable RunTableGetter(int id,int tripid)
        {

            string cn = @"Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver3;Integrated Security=True";//接続DB


            DataTable dt = new DataTable();



            string query = "SELECT TRIP_ID, JST, LATITUDE, LONGITUDE FROM [ECOLOGDBver3].[dbo].[ECOLOG_LINKS_LOOKUP2],SEMANTIC_LINKS";
            query += " WHERE TRIP_ID = " + tripid + " AND SEMANTIC_LINK_ID = " + id + " AND SEMANTIC_LINKS.LINK_ID = ECOLOG_LINKS_LOOKUP2.LINK_ID";




            using (SqlConnection SQLConn = new SqlConnection(cn))
            {
                SQLConn.FireInfoMessageEventOnUserErrors = false;

                SqlDataAdapter da = new SqlDataAdapter(query, cn);

                //DBからデータを取得しDataTableへ格納
                try
                {
                    SQLConn.Open();
                    SqlCommand cmd = new SqlCommand(query, SQLConn);
                    // cmd.CommandTimeout = 600;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception e)
                {
                    Console.Write("Inner exception: {0}", e.Message);
                }
                finally
                {
                    SQLConn.Close();

                }
            }


            Console.WriteLine("aaaaaaaaaaaaaaa");
            return dt;
		}

		//public static DataTable LinkTableGetter2(string id1, string id2, string id3, string id4, string id5, string id6, string id7, string id8, string id9, string id10, string id11, string id12, string id13, string id14, string id15, string id16, string id17, string id18, string id19, string id20, string id21, string id22, string id23, string id24, string id25, string id26, string id27, string id28, string id29, string id30, string id31, string id32, string id33, string id34, string id35, string id36, string id37, string id38, string id39, string id40, string id41, string id42, string id43, string id44, string id45, string id46, string id47, string id48, string id49, string id50, string id51, string id52, string id53, string id54, string id55, string id56, string id57, string id58, string id59, string id60, string id61, string id62, string id63, string id64, string id65, string id66, string id67, string id68, string id69, string id70, string id71, string id72, string id73, string id74, string id75, string id76, string id77, string id78, string id79, string id80, string id81, string id82, string id83, string id84, string id85, string id86, string id87, string id88, string id89, string id90, string id91, string id92, string id93, string id94, string id95, string id96, string id97, string id98, string id99, string id100, string id101, string id102, string id103, string id104, string id105, string id106, string id107, string id108, string id109, string id110, string id111, string id112, string id113, string id114, string id115,string id116)


		public static DataTable LinkTableGetter2(string id)
		{

             string cn = @"Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver3;Integrated Security=True";//接続DB


        DataTable dt = new DataTable();



			//string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			//query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID and l1.LINK_ID = SEMANTIC_LINKS.LINK_ID and SEMANTIC_LINK_ID in (" + id + ")";
			//query += " group by l1.NUM) select l1.LINK_ID as LINK_ID ,l1.NUM as START_NUM,l2.NUM as END_NUM,  l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			//query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			//query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";
			//query += " group by l1.NUM) select l1.LINK_ID as LINK_ID , l1.NUM, l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			//query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			//query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";


			//string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			//query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID  and l1.LINK_ID in ('" + id1 + "','" + id2 + "','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + id7 + "','" + id8 + "','" + id9 + "','" + id10 + "','" + id11 + "','" + id12 + "','" + id13 + "','" + id14 + "','" + id15 + "','" + id16 + "','" + id17 + "','" + id18 + "','" + id19 + "','" + id20 + "','" + id21 + "','" + id22 + "','" + id23 + "','" + id24 + "','" + id25 + "','" + id26 + "','" + id27 + "','" + id28 + "','" + id29 + "','" + id30 + "','" + id31 + "','" + id32 + "','" + id33 + "','" + id34 + "','" + id35 + "','" + id36 + "','" + id37 + "','" + id38 + "','" + id39 + "','" + id40 + "','" + id41 + "','" + id42 + "','" + id43 + "','" + id44 + "','" + id45 + "')";
			//query += " group by l1.NUM) select l1.LINK_ID as LINK_ID ,l1.NUM as START_NUM,l2.NUM as END_NUM,  l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			//query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			//query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";

			//string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			//query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID  and l1.LINK_ID in ('" + id1 + "','" + id2 + "','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + id7 + "','" + id8 + "','" + id9 + "','" + id10 + "','" + id11 + "','" + id12 + "','" + id13 + "','" + id14 + "','" + id15 + "','" + id16 + "','" + id17 + "','" + id18 + "','" + id19 + "','" + id20 + "','" + id21 + "','" + id22 + "','" + id23 + "','" + id24 + "','" + id25 + "','" + id26 + "','" + id27 + "','" + id28 + "','" + id29 + "')";
			//query += " group by l1.NUM) select l1.LINK_ID as LINK_ID ,l1.NUM as START_NUM,l2.NUM as END_NUM,  l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			//query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			//query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";


			//string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			//query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID  and l1.LINK_ID in ('" + id1 + "','" + id2 + "','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + id7 + "','" + id8 + "','" + id9 + "','" + id10 + "','" + id11 + "','" + id12 + "','" + id13 + "','" + id14 + "','" + id15 + "','" + id16 + "','" + id17 + "','" + id18 + "','" + id19 + "','" + id20 + "','" + id21 + "','" + id22 + "','" + id23 + "','" + id24 + "','" + id25 + "','" + id26 + "','" + id27 + "','" + id28 + "','" + id29 + "','" + id30 + "','" + id31 + "','" + id32 + "','" + id33 + "','" + id34 + "','" + id35 + "','" + id36 + "','" + id37 + "','" + id38 + "','" + id39 + "','" + id40 + "','" + id41 + "','" + id42 + "','" + id43 + "','" + id44 + "','" + id45 + "','" + id46 + "','" + id47 + "','" + id48 + "','" + id49 + "','" + id50 + "','" + id51 + "','" + id52 + "','" + id53 + "','" + id54 + "','" + id55 + "','" + id56 + "','" + id57 + "','" + id58 + "','" + id59 + "','" + id60 + "','" + id61 + "','" + id62 + "','" + id63 + "','" + id64 + "','" + id65 + "','" + id66 + "','" + id67 + "','" + id68 + "','" + id69 + "','" + id70 + "','" + id71 + "','" + id72 + "','" + id73 + "','" + id74 + "','" + id75 + "','" + id76 + "','" + id77 + "','" + id78 + "','" + id79 + "','" + id80 + "','" + id81 + "','" + id82 + "','" + id83 + "','" + id84 + "','" + id85 + "','" + id86 + "','" + id87 + "','" + id88 + "','" + id89 + "','" + id90 + "','" + id91 + "','" + id92 + "','" + id93 + "','" + id94 + "','" + id95 + "','" + id96 + "','" + id97 + "','" + id98 + "','" + id99 + "','" + id100 + "','" + id101 + "','" + id102 + "','" + id103 + "','" + id104 + "','" + id105 + "','" + id106 + "','" + id107 + "','" + id108 + "','" + id109 + "','" + id110 + "','" + id111 + "','" + id112 + "','" + id113 + "','" + id114 + "','" + id115 + "','" + id116 + "')";
			//query += " group by l1.NUM) select l1.LINK_ID as LINK_ID ,l1.NUM as START_NUM,l2.NUM as END_NUM,  l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			//query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			//query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";



			string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID  and l1.LINK_ID = " + id;
			query += " group by l1.NUM) select l1.LINK_ID as LINK_ID ,l1.NUM as START_NUM,l2.NUM as END_NUM,  l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";



			using (SqlConnection SQLConn = new SqlConnection(cn))
            {
                SQLConn.FireInfoMessageEventOnUserErrors = false;

                SqlDataAdapter da = new SqlDataAdapter(query, cn);

                //DBからデータを取得しDataTableへ格納
                try
                {
                    SQLConn.Open();
                    SqlCommand cmd = new SqlCommand(query, SQLConn);
					cmd.CommandTimeout = 600;
					da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception e)
                {
                    Console.Write("Inner exception: {0}", e.Message);
                }
                finally
                {
                    SQLConn.Close();
                   
                }
            }

            return dt;
        }


		#region 新規DBアクセス

		public static DataTable LinkTableGetter3(int id)
		{

			string cn = @"Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver3;Integrated Security=True";//接続DB


			DataTable dt = new DataTable();



			string query = "LINK_test";//クエリ記入

			using (SqlConnection SQLConn = new SqlConnection(cn))
			{
				SQLConn.FireInfoMessageEventOnUserErrors = false;

				SqlDataAdapter da = new SqlDataAdapter(query, cn);

				//DBからデータを取得しDataTableへ格納
				try
				{
					SQLConn.Open();
					SqlCommand cmd = new SqlCommand(query, SQLConn);
					// cmd.CommandTimeout = 600;
					da.SelectCommand = cmd;
					da.Fill(dt);
				}
				catch (Exception e)
				{
					Console.Write("Inner exception: {0}", e.Message);
				}
				finally
				{
					SQLConn.Close();

				}
			}

			return dt;
		}

		#endregion


		public static void InsertSegment(List<SegmentData> result)
        {

            string cn = @"Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver4;Integrated Security=True";//接続DB


            String insertString;
            for (int i = 0; i < result.Count; i++) {
                insertString = makeQuerySegmentData(result[i]);

                using (SqlConnection sqlConnection = new SqlConnection(cn))
                {
                    sqlConnection.Open();
                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.Transaction = sqlTransaction;
                    try
                    {
                        sqlCommand.CommandText = insertString;
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        sqlTransaction.Rollback();
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }
        public static void InsertLinkList(List<LinkListData> result)
        {

         string cn = @"Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver4;Integrated Security=True";//接続DB

            String insertString;
            for (int i = 0; i < result.Count; i++)
            {
                insertString = makeQueryLinkList(result[i]);

                using (SqlConnection sqlConnection = new SqlConnection(cn))
                {
                    sqlConnection.Open();
                    SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.Transaction = sqlTransaction;
                    try
                    {
                        sqlCommand.CommandText = insertString;
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        sqlTransaction.Rollback();
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }
        public static string makeQuerySegmentData(SegmentData data)
        {
            string query = "INSERT INTO [50M_SEGMENT] VALUES ('" + data.SEGMENT_ID + "','" + data.SEMANTIC_LINK_ID + "','" + data.START_LINK_ID + "','";
            query += data.START_NUM + "','" + data.START_POINT_OFFSET +  "')";

            return query;
        }
        public static string makeQueryLinkList(LinkListData data)
        {
            string query = "INSERT INTO [LINK_LIST_50M] VALUES ('" + data.SEGMENT_ID + "','" + data.SEMANTIC_LINK_ID + "','" + data.LINK_NUMBER + "','";
            query += data.LINK_ID + "')";

            return query;
        }
    }
}
