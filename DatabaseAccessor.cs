﻿using System;
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

        public static DataTable LinkTableGetter2(string id1, string id2,string id3, string id4, string id5, string id6, string id7, string id8, string id9, string id10/*, string id11, string id12, string id13, string id14, string id15, string id16, string id17, string id18, string id19, string id20, string id21, string id22, string id23, string id24, string id25, string id26*/)
        {

             string cn = @"Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver3;Integrated Security=True";//接続DB


        DataTable dt = new DataTable();



			//string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			//query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID and l1.LINK_ID = SEMANTIC_LINKS.LINK_ID and SEMANTIC_LINK_ID in (" + id + ")";
			//query += " group by l1.NUM) select l1.LINK_ID as LINK_ID , l1.NUM, l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			//query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			//query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";


			//string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			//query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID  and l1.LINK_ID in ('" + id1 + "','"+ id2 +"','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + id7 + "','" + id8 + "','" + id9 + "','" + id10 + "','" + id11 + "','" + id12 + "','" + id13 + "','" + id14 + "','" + id15 + "','" + id16 + "','" + id17 + "','" + id18 + "','" + id19 + "','" + id20 + "','" + id21 + "','" + id22 + "','" + id23 + "','" + id4 + "','" + id25 + "','" + id26 + "')";
			//query += " group by l1.NUM) select l1.LINK_ID as LINK_ID ,l1.NUM as START_NUM,l2.NUM as END_NUM,  l1.LATITUDE as START_LAT, l1.LONGITUDE as START_LONG,";
			//query += " l2.LATITUDE as END_LAT, l2.LONGITUDE as END_LONG ,[dbo].[Hubeny](l1.LATITUDE,l1.LONGITUDE,l2.LATITUDE,l2.LONGITUDE) as DISTANCE";
			//query += " from LINKS as l1,LINKS as l2,Corres where l1.NUM = Corres.NUM and l1.LINK_ID = l2.LINK_ID and ABS(l2.NUM-l1.NUM) =  Corres.diff";

			string query = "WITH Corres AS (select l1.NUM,MIN(ABS(l2.NUM - l1.NUM)) as diff from LINKS as l1,LINKS as l2,SEMANTIC_LINKS";
			query += " where l1.NUM != l2.NUM and l1.LINK_ID = l2.LINK_ID  and l1.LINK_ID in ('" + id1 + "','" + id2 + "','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + id7 + "','" + id8 + "','" + id9 + "','" + id10 + "')";
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
