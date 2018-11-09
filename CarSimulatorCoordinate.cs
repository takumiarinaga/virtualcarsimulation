using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SegmentInserter
{
	public partial class SegmentInserter : Form
	{
		public SegmentInserter()
		{
			InitializeComponent();
		}
		//StartInsertボタンをクリックすると開始
		private void button1_Click(object sender, EventArgs e)
		{
			#region 初期化
			List<SegmentData> resultSegment = new List<SegmentData>();
			List<LinkListData> resultLinkList = new List<LinkListData>();
			List<CoodinateData> resultCoodinate = new List<CoodinateData>();
			List<RealCarPositionMatchingData> resultrealcarmatching = new List<RealCarPositionMatchingData>();
			List<VirtualCarPositionData> resultCarPositionData = new List<VirtualCarPositionData>();

			//int id = 0;
			string id1 = "0";
			string id2 = "0";
			string id3 = "0";
			string id4 = "0";
			string id5 = "0";
			string id6 = "0";
			string id7 = "0";
			string id8 = "0";
			string id9 = "0";
			string id10 = "0";
			string id11= "0";
			string id12= "0";
			string id13= "0";
			string id14= "0";
			string id15= "0";
			string id16= "0";
			string id17= "0";
			string id18= "0";
			string id19 = "0";
			string id20 = "0";
			string id21 = "0";
			string id22 = "0";
			string id23 = "0";
			string id24 = "0";
			string id25 = "0";
			string id26 = "0";
			string id27 = "0";
			string id28 = "0";
			string id29 = "0";
			string id30 = "0";
			string id31 = "0";
			string id32 = "0";
			string id33 = "0";
			string id34 = "0";
			string id35 = "0";
			string id36 = "0";
			string id37 = "0";
			string id38 = "0";
			string id39 = "0";
			string id40 = "0";
			string id41 = "0";
			string id42 = "0";
			string id43 = "0";
			string id44 = "0";
			string id45 = "0";
			string id46 = "0";
			string id47 = "0";
			string id48 = "0";
			string id49 = "0";
			string id50 = "0";
			string id51 = "0";
			string id52 = "0";
			string id53 = "0";
			string id54 = "0";
			string id55 = "0";
			string id56 = "0";
			string id57 = "0";
			string id58 = "0";
			string id59 = "0";
			string id60 = "0";
			string id61 = "0";
			string id62 = "0";
			string id63 = "0";
			string id64 = "0";
			string id65 = "0";
			string id66 = "0";
			string id67 = "0";
			string id68 = "0";
			string id69 = "0";
			string id70 = "0";
			string id71 = "0";
			string id72 = "0";
			string id73 = "0";
			string id74 = "0";
			string id75 = "0";
			string id76 = "0";
			string id77 = "0";
			string id78 = "0";
			string id79 = "0";
			string id80 = "0";
			string id81 = "0";
			string id82 = "0";
			string id83 = "0";
			string id84 = "0";
			string id85 = "0";
			string id86 = "0";
			string id87 = "0";
			string id88 = "0";
			string id89 = "0";
			string id90 = "0";
			string id91 = "0";
			string id92 = "0";
			string id93 = "0";
			string id94 = "0";
			string id95 = "0";
			string id96 = "0";
			string id97 = "0";
			string id98 = "0";
			string id99 = "0";
			string id100 = "0";
			string id101 = "0";
			string id102 = "0";
			string id103 = "0";
			string id104 = "0";
			string id105 = "0";
			string id106 = "0";
			string id107 = "0";
			string id108 = "0";
			string id109 = "0";
			string id110 = "0";
			string id111 = "0";
			string id112 = "0";
			string id113 = "0";
			string id114 = "0";
			string id115 = "0";
			string id116 = "0";


			//通勤ルートのセマンティックリンクID
			//int tripid = 0;
			//int NumofCar = 0;//シミュレーションで生成する車の数
			//int carspeed = 60;//車の速度

			//フォームのテキストボックスからIDなどを取得
			//id = Convert.ToInt32(textBox1.Text);
			//tripid = Convert.ToInt32(textBox4.Text);
			//NumofCar = Convert.ToInt32(textBox5.Text);

			//outward用（保土ヶ谷BP→横浜新道）
			//id1 = "RB140900749198";
			//id2 = "RB140900749199";
			//id3 = "RB140900749367";
			//id4 = "RB140900749200";
			//id5 = "RB140900749201";
			//id6 = "RB140900749364";
			//id7 = "RB140900749095";
			//id8 = "RB140900749096";
			//id9 = "RB140900749203";
			//id10 = "RB140900749204";
			//id11 = "RB140900749205";
			//id12 = "RB140900748973";
			//id13 = "RB140900748995";
			//id14 = "RB140900673052";
			//id15 = "RB140900683088";
			//id16 = "RB140900683087";
			//id17 = "RB140900683095";
			//id18 = "RB140900673069";
			//id19 = "RB140900562028";
			//id20 = "RB140900562037";
			//id21 = "RB140900557235";
			//id22 = "RB140900557239";
			//id23 = "RB140900557068";
			//id24 = "RB140900557067";
			//id25 = "RB140900557248";
			//id26 = "RB140900557246";


			//homeward全部
			//id1 = "RB140900557239";
			//id2 = "RB140900557235";
			//id3 = "RB140900562037";
			//id4 = "RB140900562028";
			//id5 = "RB140900673069";
			//id6 = "RB140900683095";
			//id7 = "RB140900683094";
			//id8 = "RB140900683097";
			//id9 = "RB140900683749";
			//id10 = "RB140900683080";
			//id11 = "RB140900683081";
			//id12 = "RB140900683191";
			//id13 = "RB140900673048";
			//id14 = "RB140900748991";
			//id15 = "RB140900748992";
			//id16 = "RB140900748997";
			//id17 = "RB140900749001";
			//id18 = "RB140900735341";
			//id19 = "RB140900735342";
			//id20 = "RB140900520255";
			//id21 = "RB140900520239";
			//id22 = "RB140900520073";
			//id23 = "RB140900517833";
			//id24 = "RB140900517636";
			//id25 = "RB140900517624";
			//id26 = "RB140900510309";

			//homeward横浜新道
			//id1 = "RB140900557239";
			//id2 = "RB140900557235";
			//id3 = "RB140900562037";
			//id4 = "RB140900562028";
			//id5 = "RB140900673069";
			//id6 = "RB140900683095";
			//id7 = "RB140900683094";
			//id8 = "RB140900683097";

			//homeward保土ヶ谷BP
			//id1 = "RB140900749001";
			//id2 = "RB140900735341";
			//id3 = "RB140900735342";
			//id4 = "RB140900520255";
			//id5 = "RB140900520239";
			//id6 = "RB140900520073";
			//id7 = "RB140900517833";
			//id8 = "RB140900517636";
			//id9 = "RB140900517624";
			//id10 = "RB140900510309";


			//オロロンライン
			//id1 = "RB910000000101";
			//id2 = "RB910000000102";
			//id3 = "RB910000000103";
			//id4 = "RB910000000104";
			//id5 = "RB910000000105";
			//id6 = "RB910000000106";
			//id7 = "RB910000000107";
			//id8 = "RB910000000108";
			//id9 = "RB910000000109";
			//id10 = "RB910000000110";
			//id11 = "RB910000000111";
			//id12 = "RB910000000112";
			//id13 = "RB910000000113";
			//id14 = "RB910000000114";
			//id15 = "RB910000000115";
			//id16 = "RB910000000116";
			//id17 = "RB910000000117";
			//id18 = "RB910000000118";
			//id19 = "RB910000000119";
			//id20 = "RB910000000120";
			//id21 = "RB910000000121";
			//id22 = "RB910000000122";
			//id23 = "RB910000000123";
			//id24 = "RB910000000124";
			//id25 = "RB910000000125";
			//id26 = "RB910000000126";
			//id27 = "RB910000000127";
			//id28 = "RB910000000128";
			//id29 = "RB910000000129";
			//id30 = "RB910000000130";
			//id31 = "RB910000000131";
			//id32 = "RB910000000132";
			//id33 = "RB910000000133";
			//id34 = "RB910000000134";
			//id35 = "RB910000000135";
			//id36 = "RB910000000136";
			//id37 = "RB910000000137";
			//id38 = "RB910000000138";
			//id39 = "RB910000000139";
			//id40 = "RB910000000140";
			//id41 = "RB910000000141";
			//id42 = "RB910000000142";
			//id43 = "RB910000000143";
			//id44 = "RB910000000144";
			//id45 = "RB910000000145";
			//id46 = "RB910000000146";
			//id47 = "RB910000000147";
			//id48 = "RB910000000148";
			//id49 = "RB910000000149";
			//id50 = "RB910000000150";
			//id51 = "RB910000000151";
			//id52 = "RB910000000152";
			//id53 = "RB910000000153";
			//id54 = "RB910000000154";
			//id55 = "RB910000000155";
			//id56 = "RB910000000156";
			//id57 = "RB910000000157";
			//id58 = "RB910000000158";
			//id59 = "RB910000000159";
			//id60 = "RB910000000160";
			//id61 = "RB910000000161";
			//id62 = "RB910000000162";
			//id63 = "RB910000000163";
			//id64 = "RB910000000164";
			//id65 = "RB910000000165";
			//id66 = "RB910000000166";
			//id67 = "RB910000000167";
			//id68 = "RB910000000168";
			//id69 = "RB910000000169";
			//id70 = "RB910000000170";
			//id71 = "RB910000000171";
			//id72 = "RB910000000172";
			//id73 = "RB910000000173";
			//id74 = "RB910000000174";
			//id75 = "RB910000000175";
			//id76 = "RB910000000176";
			//id77 = "RB910000000177";
			//id78 = "RB910000000178";
			//id79 = "RB910000000179";
			//id80 = "RB910000000180";
			//id81 = "RB910000000181";
			//id82 = "RB910000000182";
			//id83 = "RB910000000183";
			//id84 = "RB910000000184";


			//東名まで


			//id1 = "RB140900557239";
			//id2 = "RB140900557235";
			//id3 = "RB140900562037";
			//id4 = "RB140900562028";
			//id5 = "RB140900673069";
			//id6 = "RB140900683095";
			//id7 = "RB140900683094";
			//id8 = "RB140900683097";
			//id9 = "RB140900683749";
			//id10 = "RB140900683080";
			//id11 = "RB140900683081";
			//id12 = "RB140900683191";
			//id13 = "RB140900673048";
			//id14 = "RB140900748991";
			//id15 = "RB140900748992";
			//id16 = "RB140900748997";
			//id17 = "RB140900749001";
			//id18 = "RB140900735341";
			//id19 = "RB140900735342";
			//id20 = "RB140900520255";
			//id21 = "RB140900520239";
			//id22 = "RB140900520073";
			//id23 = "RB140900517833";
			//id24 = "RB140900517636";
			//id25 = "RB140900517624";
			//id26 = "RB140900510309";
			//id27 = "RB140900510372";
			//id28 = "RB140900510292";
			//id29 = "RB140900509897";
			//id30 = "RB140900520263";
			//id31 = "RB140900520262";
			//id32 = "RB140900509725";
			//id33 = "RB140900520420";
			//id34 = "RB140900500468";
			//id35 = "RB140900500470";
			//id36 = "RB140900503889";
			//id37 = "RB140900503557";
			//id38 = "RB140900503518";
			//id39 = "RB140900503477";
			//id40 = "RB140900503484";
			//id41 = "RB140900520289";
			//id42 = "RB140900501157";
			//id43 = "RB140900501153";
			//id44 = "RB140900501148";
			//id45 = "RB140900501134";



			//東名から
			id1 = "RB140900503933";
			id2 = "RB140900503413";
			id3 = "RB140900503414";
			id4 = "RB140900507514";
			id5 = "RB140900507354";
			id6 = "RB140900500334";
			id7 = "RB140900761070";
			id8 = "RB140900761157";
			id9 = "RB140900761992";
			id10 = "RB140900761995";
			id11 = "RB140900929341";
			id12 = "RB140900904710";
			id13 = "RB140900904538";
			id14 = "RB140900904707";
			id15 = "RB140900904533";
			id16 = "RB140900904706";
			id17 = "RB140900904530";
			id18 = "RB140900906694";
			id19 = "RB140900906640";
			id20 = "RB140900906641";
			id21 = "RB140900906642";
			id22 = "RB140900803989";
			id23 = "RB140900803735";
			id24 = "RB140900803990";
			id25 = "RB140900803736";
			id26 = "RB140900803991";
			id27 = "RB140900803738";
			id28 = "RB140900803997";
			id29 = "RB140900802880";




			//小田厚木
			//id1 = "RB140900803023";
			//id2 = "RB140900803441";
			//id3 = "RB140900803442";
			//id4 = "RB140900804746";
			//id5 = "RB140900804902";
			//id6 = "RB140900804809";
			//id7 = "RB140900814530";
			//id8 = "RB140900814542";
			//id9 = "RB140900814547";
			//id10 = "RB140900814619";
			//id11 = "RB140900814625";
			//id12 = "RB140900814624";
			//id13 = "RB140900816398";
			//id14 = "RB140900816399";
			//id15 = "RB140900834371";
			//id16 = "RB140900834380";
			//id17 = "RB140900834385";
			//id18 = "RB140900834427";
			//id19 = "RB140900834431";
			//id20 = "RB140900834434";
			//id21 = "RB140900834435";
			//id22 = "RB140900835995";
			//id23 = "RB140900835993";
			//id24 = "RB140900836011";
			//id25 = "RB140900835994";
			//id26 = "RB140900836004";
			//id27 = "RB140900836261";
			//id28 = "RB140900836119";
			//id29 = "RB140900833179";
			//id30 = "RB140900832924";
			//id31 = "RB140900832988";
			//id32 = "RB140900853266";
			//id33 = "RB140900853270";
			//id34 = "RB140900853272";
			//id35 = "RB140900853271";
			//id36 = "RB140900874935";
			//id37 = "RB140900874899";
			//id38 = "RB140900874369";
			//id39 = "RB140900874316";
			//id40 = "RB140900874321";
			//id41 = "RB140900874320";
			//id42 = "RB140900874318";
			//id43 = "RB140900874314";
			//id44 = "RB140900874368";
			//id45 = "RB140900874331";
			//id46 = "RB140900874333";
			//id47 = "RB140900874332";
			//id48 = "RB140900874367";
			//id49 = "RB140900874323";
			//id50 = "RB140900872092";
			//id51 = "RB140900873729";
			//id52 = "RB140900873792";
			//id53 = "RB140900873728";
			//id54 = "RB140900873791";
			//id55 = "RB140900873727";
			//id56 = "RB140900873790";
			//id57 = "RB140900873726";
			//id58 = "RB140900873789";
			//id59 = "RB140900873725";
			//id60 = "RB140900872826";
			//id61 = "RB140900872736";
			//id62 = "RB140900872827";
			//id63 = "RB140900872775";
			//id64 = "RB140900872829";
			//id65 = "RB140900872778";
			//id66 = "RB140900872831";
			//id67 = "RB140900872737";
			//id68 = "RB140900888394";
			//id69 = "RB140900888021";
			//id70 = "RB140900888061";
			//id71 = "RB140900888426";
			//id72 = "RB140900887829";
			//id73 = "RB140900887818";
			//id74 = "RB140900887817";
			//id75 = "RB140900887717";
			//id76 = "RB140900884725";
			//id77 = "RB140900884783";
			//id78 = "RB140900886643";
			//id79 = "RB140900886642";
			//id80 = "RB140900886579";
			//id81 = "RB140900886578";
			//id82 = "RB140900886577";
			//id83 = "RB140900886582";
			//id84 = "RB140900886583";
			//id85 = "RB140900886584";
			//id86 = "RB140900886585";
			//id87 = "RB140900886586";
			//id88 = "RB140900886620";
			//id89 = "RB140900886621";
			//id90 = "RB140900886622";
			//id91 = "RB140900886623";
			//id92 = "RB140900886624";
			//id93 = "RB140900886625";
			//id94 = "RB140900886613";
			//id95 = "RB140900886614";
			//id96 = "RB140900886612";
			//id97 = "RB140900886611";
			//id98 = "RB140900886604";
			//id99 = "RB140900886605";
			//id100= "RB140900886199";
			//id101 = "RB140900886217";
			//id102 = "RB140900886231";
			//id103 = "RB140900894443";
			//id104 = "RB140900895655";
			//id105 = "RB140900895656";
			//id106 = "RB140900894333";
			//id107 = "RB140900894334";
			//id108 = "RB140900894327";
			//id109 = "RB140900894147";
			//id110 = "RB140900894095";
			//id111 = "RB140900894298";
			//id112 = "RB140900896223";
			//id113 = "RB140900896305";
			//id114 = "RB140900896303";
			//id115 = "RB140900895900";
			//id116 = "RB140900896337";





			//tripid = 11;
			//NumofCar = 100;


			int startNum = 0;
			int endNum = 0;
			//id = Convert.ToString(textBox10.Text);
			//startNum = Convert.ToInt32(textBox2.Text);
			//endNum = Convert.ToInt32(textBox3.Text);


			//startNum = 868676;//通勤セマンティックリンクのスタート地点指定
			//endNum = 196284;//通勤セマンティックリンクのエンド地点指定


			//homeward全部
			//startNum = 196228;//通勤セマンティックリンクのスタート地点指定
			//endNum = 40254;//通勤セマンティックリンクのエンド地点指定


			////homeward横浜新道のみ
			//startNum = 196228;//通勤セマンティックリンクのスタート地点指定
			//endNum = 640396;//通勤セマンティックリンクのエンド地点指定



			////homeward保土ヶ谷BPのみ
			//startNum = 867754;//通勤セマンティックリンクのスタート地点指定
			//endNum = 40254;//通勤セマンティックリンクのエンド地点指定


			//オロロンライン
			//startNum = 1952067;
			//endNum = 1952633;

			//東名まで
			//startNum = 196228;
			//endNum = 4794;

			//東名から
			startNum = 18099;
			endNum = 1109823;


			//小田厚木
			//startNum = 1110404;
			//endNum = 1540508;

			#endregion

			//int geti = 0;

			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id);//セマンティックリンクIDからセマンティックリンクデータを取得



			//outward・homeward用DB
			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2,id3,id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15, id16, id17, id18, id19, id20, id21, id22, id23, id24, id25,id26);
			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2, id3);


			//homeward横浜新道
			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2, id3, id4, id5, id6, id7, id8);

			//homeward保土ヶ谷BP
			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2, id3, id4, id5, id6, id7, id8, id9, id10);


			//オロロンライン
			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2,id3,id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15, id16, id17, id18, id19, id20, id21, id22, id23, id24, id25,id26,id27, id28, id29, id30, id31, id32, id33, id34, id35, id36, id37, id38, id39, id40, id41, id42, id43, id44, id45, id46, id47, id48, id49, id50, id51, id52, id53, id54, id55, id56, id57, id58, id59, id60, id61, id62, id63, id64, id65, id66, id67, id68, id69, id70, id71, id72, id73, id74, id75, id76, id77, id78, id79, id80, id81, id82, id83, id84);

			//東名まで
			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15, id16, id17, id18, id19, id20, id21, id22, id23, id24, id25, id26, id27, id28, id29, id30, id31, id32, id33, id34, id35, id36, id37, id38, id39, id40, id41, id42, id43, id44, id45);


			//東名から
			DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15, id16, id17, id18, id19, id20, id21, id22, id23, id24, id25, id26, id27, id28, id29);

			//小田厚木
			//DataTable LinkTable = DatabaseAccessor.LinkTableGetter2(id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15, id16, id17, id18, id19, id20, id21, id22, id23, id24, id25, id26, id27, id28, id29, id30, id31, id32, id33, id34, id35, id36, id37, id38, id39, id40, id41, id42, id43, id44, id45, id46, id47, id48, id49, id50, id51, id52, id53, id54, id55, id56, id57, id58, id59, id60, id61, id62, id63, id64, id65, id66, id67, id68, id69, id70, id71, id72, id73, id74, id75, id76, id77, id78, id79, id80, id81, id82, id83, id84, id85, id86, id87, id88, id89, id90, id91, id92, id93, id94, id95, id96, id97, id98, id99, id100, id101, id102, id103, id104, id105, id106, id107, id108, id109, id110, id111, id112, id113, id114, id115,id116);


			DataRow[] LinkRows = LinkTable.Select(null, "DISTANCE");//LinkTableをカラムDISTANCEでソートしてDataRow配列に変換
			DataRow[] StartLink = LinkTable.Select("START_NUM = " + startNum);//通勤セマンティックリンクのスタート地点のリンク構成点データだけ取り出し
			List<LinkData> linkList = new List<LinkData>();//リンクデータリスト追加

			Console.WriteLine(1);

			linkList.Add(new LinkData(Convert.ToString(StartLink[0]["LINK_ID"]), Convert.ToInt32(StartLink[0]["START_NUM"]),
				Convert.ToDouble(StartLink[0]["START_LAT"]), Convert.ToDouble(StartLink[0]["START_LONG"]),
				Convert.ToDouble(StartLink[0]["END_LAT"]), Convert.ToDouble(StartLink[0]["END_LONG"]), Convert.ToDouble(StartLink[0]["DISTANCE"])));//スタート地点のリンク構成点データをadd

			Console.WriteLine(2);

			#region 通勤リンクデータ結合処理
			Boolean flag = true;//結合できたか否かを判定するフラグ
			int j = 0;//linkList配列の最後尾を示すindex
			while (flag)
			{
				flag = false;//Link結合がされなければtrueにならずにループ終了
				for (int i = 0; i < LinkRows.Length; i++)//LinkRowsから結合可能なLinkを探索
				{
					if ((Convert.ToDouble(LinkRows[i]["START_LAT"]) == linkList[j].END_LAT && Convert.ToDouble(LinkRows[i]["START_LONG"]) == linkList[j].END_LONG)
						&& (Convert.ToDouble(LinkRows[i]["END_LAT"]) != linkList[j].START_LAT || Convert.ToDouble(LinkRows[i]["END_LONG"]) != linkList[j].START_LONG))//linklistの最後尾の値に結合可能なlinkのみを追加する
					{


						linkList.Add(new LinkData(Convert.ToString(LinkRows[i]["LINK_ID"]), Convert.ToInt32(LinkRows[i]["START_NUM"]),
													  Convert.ToDouble(LinkRows[i]["START_LAT"]), Convert.ToDouble(LinkRows[i]["START_LONG"]),
													  Convert.ToDouble(LinkRows[i]["END_LAT"]), Convert.ToDouble(LinkRows[i]["END_LONG"]), Convert.ToDouble(LinkRows[i]["DISTANCE"])));//該当LinkをLinklistに追加
						j++;//linkListにデータが追加されたので最後尾をUpdate
						Console.WriteLine(0);

						flag = true;//Link結合されたのでtrueに書き換え
						StateLabel.Text = Convert.ToString(linkList.Count);
						StateLabel.Update();
						break;//結合が終わったので次のループへ進む

					}



				}

			}
			#endregion

			Console.WriteLine(3);

			#region ここは多分消していい
			//DataTable RunTable = DatabaseAccessor.RunTableGetter(id, tripid);      //走行データ取得
			//List<RunData> runList = new List<RunData>();

			//DataRow[] RunRows = RunTable.Select(null, "JST");//走行データを時間でソートしてDataRowに変換
			// for (int i = 0; i < RunRows.Length; i++)
			//{
			//    runList.Add(new RunData(Convert.ToInt32(RunRows[i]["TRIP_ID"]),Convert.ToString(RunRows[i]["JST"]), Convert.ToDouble(RunRows[i]["LATITUDE"]),
			//                                            Convert.ToDouble(RunRows[i]["LONGITUDE"])));//DataRow[]をList<RunData>に変換
			// }




			// resultrealcarmatching = MatchingCarPosition(linkList, runList);//Link上の実ログデータの位置を算出
			#endregion

			//makePositionDataを書き換えれば完了
			resultCarPositionData = virtualcarPositionData(linkList);//シミュレーションデータを生成

			//resultCoodinate = makeCoodinateData(linkList, resultCarPositionData);//Link上の位置から座標データに変換
			//WriteCsv(resultCoodinate, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));//CSVに書き出し
			CsvWriter(resultCarPositionData);





		}





		//private static void WriteCsv(List<CoodinateData> resultcoordinate, int semantici_id, int trip_id, int num, int distance)
		//{

		//	for (int j = 0; j < num; j++)
		//	{
		//		List<CoodinateData> insertcoordinate = new List<CoodinateData>();
		//		for (int k = 0; k < resultcoordinate.Count; k++)
		//		{
		//			if (resultcoordinate[k].CAR_NUM == j)
		//			{
		//				insertcoordinate.Add(resultcoordinate[k]);
		//				Console.WriteLine(resultcoordinate[k].LATITUDE + "  " + resultcoordinate[k].JST);
		//			}
		//		}

		//		try
		//		{
		//			// appendをtrueにすると，既存のファイルに追記
		//			//         falseにすると，ファイルを新規作成する
		//			var append = false;
		//			// 出力用のファイルを開く
		//			using (var sw = new System.IO.StreamWriter(@"C: \Users\arinaga\Documents\GitHub\CarSimulationCoordinateGenerator\" + "sim_" + semantici_id + "_" + trip_id + "_" + num + "_" + distance + "M" + j + ".csv", append))
		//			{
		//				for (int i = 0; i < insertcoordinate.Count; ++i)

		//				{

		//					DateTime dt1 = DateTime.Parse(insertcoordinate[i].JST);
		//					sw.WriteLine("{0},{1},{2},{3}", dt1.ToString("yyyy-MM-dd HH:mm:ss.FFF"),/*dt1.Year + "-" + dt1.Month + "-" + dt1.Day+ " " +dt1.TimeOfDay*/dt1.ToString("yyyy-MM-dd HH:mm:ss.FFF"), insertcoordinate[i].LATITUDE, insertcoordinate[i].LONGITUDE);
		//				}
		//			}
		//		}
		//		catch (System.Exception e)
		//		{
		//			// ファイルを開くのに失敗したときエラーメッセージを表示
		//			System.Console.WriteLine(e.Message);
		//		}


		//	}
		//}

		#region 新規csv出力メソッド
		private static void CsvWriter(List<VirtualCarPositionData> virtualCarPositionDataList)
		{
			int datacount;
			int index = 0;
			datacount = virtualCarPositionDataList.Count;
			
			DateTime dtBirth = DateTime.Now;

			System.IO.StreamWriter sw = new System.IO.StreamWriter(
					//@"C:\Users\arinaga\Desktop\" + dtBirth.ToString("yyyyMMddHHmmss")+"UnsentGPS"+".csv",
					@"\\itsserver\ECOLOG_LogData_itsserver\Arisimu\LEAFSIMU\arisimu\DrivingLoggerUnsentLog\" + dtBirth.ToString("yyyyMMddHHmmss") + "UnsentGPS" + ".csv",
					false,
					System.Text.Encoding.GetEncoding("shift_jis"));
			for (index = 0; index < datacount; index++) {
				VirtualCarPositionData virtualCarPositionData;
				double lat2;
				double long2;
				int num2;
				
				virtualCarPositionData = virtualCarPositionDataList[index];
				lat2 = virtualCarPositionData.LATITUDE;
				long2 = virtualCarPositionData.LONGITUDE;
				num2 = virtualCarPositionData.NUM;
				Console.WriteLine(dtBirth.ToString("yyyy-MM-dd HH:mm:ss.FFF") + "," + dtBirth.ToString("yyyy-MM-dd HH:mm:ss.FFF" )+ "," + lat2 + "," + long2 + "," + num2);
				
				//int colCount = virtualCarPositionDataList.Count;
				//int lastColindex = colCount - 1;

				//if (writeHeader)
				//{
				//	for (int i = 0; i < colCount; i++)
				//	{
				//		string field = virtualCarPositionDataList.

				sw.WriteLine(dtBirth.ToString("yyyy-MM-dd HH:mm:ss.FFF") + "," + dtBirth.ToString("yyyy-MM-dd HH:mm:ss.FFF") + "," + lat2 + "," + long2);
				


				dtBirth = dtBirth.AddSeconds(1);
				

			}

			sw.Close();
		}
		#endregion
	


		private List<RealCarPositionMatchingData> MatchingCarPosition(List<LinkData> linkList, List<RunData> runList)   //実際の車の位置（今回は必要ない）
		{

			List<RealCarPositionMatchingData> result = new List<RealCarPositionMatchingData>();



			for (int k = 0; k < runList.Count; k++)
			{
				double minDist = 255;
				int tempNum = 0;

				string tempLinkId = null;
				double rawstartpointoffset = 0;
				double startpointoffset = 0;


				GeoCoordinate matchinggpsPoint = new GeoCoordinate();


				for (int i = 0; i < linkList.Count; i++)
				{        //各リンクに対して
					Vector2D linkStartEdge = new Vector2D(linkList[i].START_LAT, linkList[i].START_LONG);
					Vector2D linkEndEdge = new Vector2D(linkList[i].END_LAT, linkList[i].END_LONG);
					Vector2D GPSPoint = new Vector2D(runList[k].LATITUDE, runList[k].LONGITUDE);
					//       Console.Write(GPSPoint.x+","+GPSPoint.y+"\n");


					//線分内の最近傍点を探す
					Vector2D matchedPoint = Vector2D.nearest(linkStartEdge, linkEndEdge, GPSPoint);

					//最近傍点との距離
					double tempDist = Vector2D.distance(GPSPoint, matchedPoint);




					//リンク集合の中での距離最小を探す
					if (tempDist < minDist)
					{
						GeoCoordinate linkStart = new GeoCoordinate();
						linkStart.Latitude = linkList[i].START_LAT;
						linkStart.Longitude = linkList[i].START_LONG;
						GeoCoordinate gpsPoint = new GeoCoordinate();
						gpsPoint.Latitude = runList[k].LATITUDE;
						gpsPoint.Longitude = runList[k].LONGITUDE;
						GeoCoordinate linkEnd = new GeoCoordinate();
						linkEnd.Latitude = linkList[i].END_LAT;
						linkEnd.Longitude = linkList[i].END_LONG;

						minDist = tempDist;


						tempNum = linkList[i].NUM;
						tempLinkId = linkList[i].LINK_ID;

						rawstartpointoffset = HubenyDistanceCalculator.CalcHubenyFormula(linkEnd, gpsPoint);
						//    Console.WriteLine(rawstartpointoffset);

						matchinggpsPoint = HubenyDistanceCalculator.CalcCoordinateFromHubenyFormula(linkEnd, rawstartpointoffset, linkStart);
						//   Console.WriteLine(matchinggpsPoint.Longitude);


					}
				}

				result.Add(new RealCarPositionMatchingData(runList[k].TRIP_ID, runList[k].JST, matchinggpsPoint.Latitude, matchinggpsPoint.Longitude, tempLinkId, tempNum, rawstartpointoffset));
				Console.Write(k + "   " + runList[k].JST + "   " + matchinggpsPoint.Latitude + "   " + matchinggpsPoint.Longitude + "   " + tempLinkId + "   " + tempNum + "   " + rawstartpointoffset + "\n");
			}
			return result;
		}


		private List<CarPositionData> makePositionData(List<LinkData> linkList, List<RealCarPositionMatchingData> realcarposi, int Ncar) //Ncar は台数
		{
			List<CarPositionData> result = new List<CarPositionData>();
			//  double v_distance = Convert.ToInt32(textBox6.Text);         //車速
			double v_distance = 75 * 1000 /3600;   //1秒おきに

			for (int i = 0; i < realcarposi.Count; i++)
			{
				Console.WriteLine("i = " + i);
				//  string LinkID = "";
				//  int tempNUM = realcarposi[i].NUM;
				int j = 0;

				//        result.Add(new CarPositionData(realcarposi[i].TRIP_ID, realcarposi[i].JST,0,realcarposi[i].LINK_ID,realcarposi[i].NUM,realcarposi[i].END_POINT_OFFSET));


				for (int k = 0; k < linkList.Count(); k++)
				{
					if (linkList[k].NUM == realcarposi[i].NUM)
					{
						j = k;

					}
				}


				double startPointOffset = realcarposi[i].START_POINT_OFFSET;
				Console.WriteLine(realcarposi[i].START_POINT_OFFSET);

				string LinkID = linkList[j].LINK_ID;
				int LinkNum = linkList[j].NUM;

				double rest = linkList[j].DISTANCE - realcarposi[i].START_POINT_OFFSET;
				double nextstartPointOffset = realcarposi[i].START_POINT_OFFSET;
				// double temp_v_distance = Convert.ToInt32(textBox6.Text);
				double temp_v_distance = 50 / 3;
				int carnumber = 0;

				do
				{

					if (rest > v_distance && temp_v_distance == v_distance)    //①リンクの残り長さrest＞一秒間の走行距離v_distance＆まだリンクを跨いでいない

					{
						nextstartPointOffset += temp_v_distance;
						rest = rest - temp_v_distance;
						temp_v_distance = v_distance;
						result.Add(new CarPositionData(realcarposi[i].TRIP_ID, realcarposi[i].JST, carnumber, LinkID, LinkNum, nextstartPointOffset));
						Console.WriteLine("0  " + realcarposi[i].TRIP_ID + "  " + realcarposi[i].JST + "  " + carnumber + "  " + LinkID + "  " + LinkNum + "  " + nextstartPointOffset);
						//  result.Add(new SegmentData(segmentID, semanticLinkID, startLinkID, startNum, startPointOffset));
						carnumber++;
						LinkID = linkList[j].LINK_ID;
						LinkNum = linkList[j].NUM;
						startPointOffset = nextstartPointOffset;

						//nextstartPointOffset = startPointOffset - v_distance;
						//result.Add(new CarPositionData(realcarposi[i].TRIP_ID, realcarposi[i].JST, carnumber, LinkID, tempNUM, nextstartPointOffset));
						//startPointOffset = nextstartPointOffset;

					}

					else if (rest > temp_v_distance)           //②リンクの残り長さ＞残距離&その車両について2回目以降
					{

						nextstartPointOffset = temp_v_distance;
						rest = rest - temp_v_distance;
						temp_v_distance = v_distance;
						result.Add(new CarPositionData(realcarposi[i].TRIP_ID, realcarposi[i].JST, carnumber, LinkID, LinkNum, nextstartPointOffset));
						Console.WriteLine("1  " + realcarposi[i].TRIP_ID + "  " + realcarposi[i].JST + "  " + carnumber + "  " + LinkID + "  " + LinkNum + "  " + nextstartPointOffset);
						carnumber++;
						LinkID = linkList[j].LINK_ID;
						LinkNum = linkList[j].NUM;

						startPointOffset = nextstartPointOffset;

						//j--;
						//if (j < 0) break;
						//nextstartPointOffset = linkList[j].DISTANCE - (v_distance - startPointOffset);
						//LinkID = linkList[j].LINK_ID;
						//tempNUM = linkList[j].NUM;
						//result.Add(new CarPositionData(realcarposi[i].TRIP_ID, realcarposi[i].JST, carnumber, LinkID, tempNUM, nextstartPointOffset));



					}

					else if (rest == temp_v_distance)      //③リンクの残り長さが車間距離と同じ　＝
					{



						j++;
						rest = linkList[j].DISTANCE;
						temp_v_distance = v_distance;

						LinkID = linkList[j].LINK_ID;
						LinkNum = linkList[j].NUM;

						startPointOffset = 0;
						nextstartPointOffset = v_distance;

						result.Add(new CarPositionData(realcarposi[i].TRIP_ID, realcarposi[i].JST, carnumber, LinkID, LinkNum, startPointOffset));


						Console.WriteLine("2  " + realcarposi[i].TRIP_ID + "  " + realcarposi[i].JST + "  " + carnumber + "  " + LinkID + "  " + LinkNum + "  " + nextstartPointOffset);
						carnumber++;



						//if (j < 0) break
						//nextstartPointOffset = linkList[j].DISTANCE;
						//LinkID = linkList[j].LINK_ID;
						//tempNUM = linkList[j].NUM;
						//result.Add(new CarPositionData(realcarposi[i].TRIP_ID, realcarposi[i].JST, carnumber, LinkID, tempNUM, nextstartPointOffset));
					}
					else
					{
						Console.WriteLine("3");               //   ④リンクの残り長さ＜車間距離

						temp_v_distance = temp_v_distance - rest;
						j++;

						rest = linkList[j].DISTANCE;


						LinkID = linkList[j].LINK_ID;
						LinkNum = linkList[j].NUM;

					}


				} while (carnumber < Ncar);
			}
			return result;
		}
		#region　新規走行ログシミュレート
		private List<VirtualCarPositionData> virtualcarPositionData(List<LinkData> linkList)
		{
			List<VirtualCarPositionData> result = new List<VirtualCarPositionData>();
			VirtualCarPositionData virtualCarPositionData;

			double[] speedarray = new double[] {

				48.3,
				48.77,
				48.33,
				48.74,
				47.05,
				49.94,
				49.19,
				52.11,
				52.1,
				53.28,
				53.03,
				53.78,
				54.47,
				56.59,
				56.86,
				56.55,
				56.44,
				56.03,
				55.8,
				55.82,
				54.69,
				53.72,
				52.77,
				50.98,
				49.76,
				48.64,
				47.8,
				47.07,
				46.49,
				46.68,
				45.53,
				44.65,
				44.83,
				44.64,
				44.21,
				44.48,
				43.65,
				44.61,
				46.3,
				46.8,
				48.62,
				49.98,
				50.44,
				51.43,
				52.01,
				52.19,
				53.41,
				52.31,
				52.39,
				52.78,
				50.45,
				52.11,
				51.96,
				54.36,
				54.25,
				54.69,
				54.23,
				53.35,
				54.21,
				53.81,
				52.23,
				52.68,
				49.43,
				50.35,
				50.31,
				51.41,
				51.11,
				50.26,
				50.79,
				50.31,
				49.99,
				49.48,
				48.79,
				49.02,
				48.17,
				47.68,
				46.96,
				47.83,
				48.44,
				49.34,
				48.79,
				48.85,
				51.22,
				50.78,
				51.64,
				51.78,
				53.01,
				53.01,
				53.13,
				51.68,
				52.51,
				52.27,
				51.17,
				50.93,
				50.4,
				49.58,
				48.96,
				49.98,
				49.1,
				49.13,
				48.64,
				49.42,
				50.35,
				50.52,
				51.48,
				51.82,
				52.01,
				51.91,
				51.51,
				50.8,
				51.16,
				51.14,
				50.57,
				50.94,
				51.15,
				51.31,
				51.43,
				51.66,
				51.33,
				51.8,
				52.34,
				52.2,
				52.06,
				51.01,
				50.87,
				50.51,
				49.72,
				50.49,
				50.25,
				50.89,
				51.2,
				51.72,
				51.76,
				51.43,
				51.16,
				50.95,
				50.64,
				50.58,
				50.19,
				50.83,
				50.35,
				48.73,
				50.2,
				50.18,
				48.97,
				50.19,
				48.36,
				47.83,
				48.31,

			};
			
			
			//double v3 = Convert.ToInt32(textBox4.Text);
			//double v3 = 81;
			double v = 0;
			int vcount = 0;
			int speedarraycount =149;
			//v = v3 * 1000 / 3600;
			double past = 0;
			double rest = 0;
			int restcount = 0;
			//リンクを跨いだ回数

			int posicount = 0;
			//位置を作った数

			int count = 100;
			double lat1  ;
			double long1 ;
			int num;
			double restv = 0;

			Console.WriteLine(4);
			//result[0].LATITUDE = linkList[0].START_LAT;
			//result[0].LONGITUDE = linkList[0].START_LONG;
			lat1 = linkList[0].START_LAT;
			long1 = linkList[0].START_LONG;
			num = linkList[0].NUM;

			virtualCarPositionData = new VirtualCarPositionData(lat1, long1, num);
			result.Add(virtualCarPositionData);
			// result.Add(new VirtualCarPositionData(linkList[0].START_LAT, linkList[0].START_LONG, linkList[0].NUM));


			#region 一つ目

			if (linkList[0].DISTANCE > (speedarray[0]*1000/3600)) 
				//次のリンクに移動しない場合
				{
				//result[1].LATITUDE = (linkList[0].END_LAT - linkList[0].START_LAT) * v / linkList[0].DISTANCE;
				//result[1].LONGITUDE = (linkList[0].END_LONG - linkList[0].START_LONG) * v / linkList[0].DISTANCE;
				lat1 = ((linkList[0].END_LAT - linkList[0].START_LAT) * (speedarray[0] * 1000 / 3600) / linkList[0].DISTANCE) + linkList[0].START_LAT;
				long1 = ((linkList[0].END_LONG - linkList[0].START_LONG) * (speedarray[0] * 1000 / 3600 )/ linkList[0].DISTANCE)+ linkList[0].START_LONG;
				num = linkList[0].NUM;
				past =  speedarray[0] * 1000 / 3600;

				virtualCarPositionData = new VirtualCarPositionData(lat1, long1, num);
				result.Add(virtualCarPositionData);
				vcount++;



			}

			else{//次以降のnumに移動する場合
				rest = (speedarray[0] * 1000 / 3600 )- linkList[restcount].DISTANCE;
				restcount++;
				
				while (rest>linkList[restcount].DISTANCE)
				{

					rest = rest - linkList[restcount].DISTANCE;
					restcount++;

				}
				//result[1].LATITUDE = (((linkList[count1].END_LAT - linkList[count1].START_LAT) * rest / linkList[count1].DISTANCE) + linkList[count1].START_LAT);
				//result[1].LONGITUDE = (((linkList[count1].END_LONG - linkList[count1].START_LONG) * rest / linkList[count1].DISTANCE) + linkList[count1].START_LONG);
				lat1 = (((linkList[restcount].END_LAT - linkList[restcount].START_LAT) * rest / linkList[restcount].DISTANCE) + linkList[restcount].START_LAT);
				long1 = (((linkList[restcount].END_LONG - linkList[restcount].START_LONG) * rest / linkList[restcount].DISTANCE) + linkList[restcount].START_LONG);
				num = linkList[restcount].NUM;
				past = linkList[restcount].DISTANCE - rest;

				virtualCarPositionData = new VirtualCarPositionData(lat1, long1, num);
				result.Add(virtualCarPositionData);
				vcount++;

			}

			#endregion


			#region　ループ
			while (restcount < (linkList.Count - 1))
			{
				if (linkList[restcount].DISTANCE - past > speedarray[vcount] * 1000 / 3600)//次のnumに移動しない
				{

					v = speedarray[vcount] * 1000 / 3600;
					lat1 = (linkList[restcount].END_LAT - linkList[restcount].START_LAT) * (v+past) / linkList[restcount].DISTANCE + linkList[restcount].START_LAT;
					long1 = (linkList[restcount].END_LONG - linkList[restcount].START_LONG) * (v+past) / linkList[restcount].DISTANCE + linkList[restcount].START_LONG;
					num = linkList[restcount].NUM;
					past = past + v;


					virtualCarPositionData = new VirtualCarPositionData(lat1, long1, num);
					result.Add(virtualCarPositionData);

					posicount++;
					vcount++;
					vcount = vcount % speedarraycount;
					
				}
				else//次のnumに移動する
				{
					v = speedarray[vcount] * 1000 / 3600;
					rest = linkList[restcount].DISTANCE - past;
					restv = v - rest;
					restcount++;




					while((restv > linkList[restcount].DISTANCE)&&(restcount<linkList.Count-1))
						{
							
							restv = restv - linkList[restcount].DISTANCE;
							restcount++;

						}

						lat1 = (((linkList[restcount].END_LAT - linkList[restcount].START_LAT) * restv / linkList[restcount].DISTANCE) + linkList[restcount].START_LAT);
						long1 = (((linkList[restcount].END_LONG - linkList[restcount].START_LONG) * restv / linkList[restcount].DISTANCE) + linkList[restcount].START_LONG);
						num = linkList[restcount].NUM;
						past = restv;



						virtualCarPositionData = new VirtualCarPositionData(lat1, long1, num);
						result.Add(virtualCarPositionData);

						posicount++;
						vcount++;
						vcount = vcount % speedarraycount;

				}
			}
			

			#endregion


			return result;



			#endregion




		}
		//#region　座標データ変換メソッド
		//private List<CoodinateData> makeCoodinateData(List<LinkData>linkList,List<VirtualCarPositionData>carPositionData)
		//      {
		//          int Num = 0;
		//          GeoCoordinate coordinate = new GeoCoordinate();
		//          GeoCoordinate LinkStartCoodinate  = new GeoCoordinate();
		//          GeoCoordinate LinkEndCoodinate = new GeoCoordinate();

		//          List<CoodinateData> result = new List<CoodinateData>();
		//          for (int i = 0; i < carPositionData.Count; i++)
		//          {
		//              Num = carPositionData[i].NUM;
		//              for(int k = 0; k < linkList.Count; k++) {
		//                  if (linkList[k].NUM == Num) {
		//                      LinkStartCoodinate.Latitude = linkList[k].START_LAT;
		//                      LinkStartCoodinate.Longitude = linkList[k].START_LONG;
		//                      LinkEndCoodinate.Latitude = linkList[k].END_LAT;
		//                      LinkEndCoodinate.Longitude = linkList[k].END_LONG;

		//                      break;

		//                   }

		//              }

		//              coordinate = HubenyDistanceCalculator.CalcCoordinateFromHubenyFormula(LinkEndCoodinate,carPositionData[i].START_POINT_OFFSET,LinkStartCoodinate);
		//              result.Add(new CoodinateData(carPositionData[i].TRIP_ID,carPositionData[i].CAR_NUM,coordinate.Longitude,coordinate.Latitude,carPositionData[i].JST));
		//              Console.WriteLine(carPositionData[i].TRIP_ID+" "+ carPositionData[i].CAR_NUM + " " + coordinate.Longitude + " " + coordinate.Latitude + " " + carPositionData[i].JST);

		//          }



		//          return result;

		//      }
		//#endregion




		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void SegmentInserter_Load(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
	#region class
	class LinkData
	{
		public string LINK_ID { get; set; }
		public int NUM { get; set; }
		public double START_LAT { get; set; }
		public double START_LONG { get; set; }
		public double END_LAT { get; set; }
		public double END_LONG { get; set; }

		public double DISTANCE { get; set; }

		public LinkData(String LINK_ID, int NUM, double START_LAT, double START_LONG, double END_LAT, double END_LONG, double DISTANCE)
		{
			this.LINK_ID = LINK_ID;
			this.NUM = NUM;
			this.START_LAT = START_LAT;
			this.START_LONG = START_LONG;
			this.END_LAT = END_LAT;
			this.END_LONG = END_LONG;
			this.DISTANCE = DISTANCE;
		}


	}
	class RunData
	{ public int TRIP_ID { get; set; }
		public string JST { get; set; }
		public double LATITUDE { get; set; }
		public double LONGITUDE { get; set; }


		public RunData(int TRIP_ID, String JST, double LATITUDE, double LONGITUDE)
		{
			this.TRIP_ID = TRIP_ID;
			this.JST = JST;
			this.LATITUDE = LATITUDE;
			this.LONGITUDE = LONGITUDE;

		}
	}

	class SegmentData
	{
		public int SEGMENT_ID { get; set; }
		public int SEMANTIC_LINK_ID { get; set; }
		public string START_LINK_ID { get; set; }
		public int START_NUM { get; set; }
		public double START_POINT_OFFSET { get; set; }

		//  public double ALTITUDE { get; set; }

		public SegmentData(int SEGMENT_ID, int SEMANTIC_LINK_ID, string START_LINK_ID, int START_NUM, double START_POINT_OFFSET)
		{
			this.SEGMENT_ID = SEGMENT_ID;
			this.SEMANTIC_LINK_ID = SEMANTIC_LINK_ID;
			this.START_LINK_ID = START_LINK_ID;
			this.START_NUM = START_NUM;
			this.START_POINT_OFFSET = START_POINT_OFFSET;
			//    this.ALTITUDE = ALTITUDE;
		}
	}

	class CoodinateData
	{
		public int TRIP_ID { get; set; }
		public int CAR_NUM { get; set; }
		public double LONGITUDE { get; set; }
		public double LATITUDE { get; set; }
		public string JST { get; set; }

		//  public double ALTITUDE { get; set; }

		public CoodinateData(int TRIP_ID, int CAR_NUM, double LONGITUDE, double LATITUDE, string JST)
		{
			this.TRIP_ID = TRIP_ID;
			this.CAR_NUM = CAR_NUM;
			this.LONGITUDE = LONGITUDE;
			this.LATITUDE = LATITUDE;
			this.JST = JST;

		}
	}


	class CarPositionData {

		public int TRIP_ID { get; set; }

		public string JST { get; set; }

		public int CAR_NUM { get; set; }
		public string LINK_ID { get; set; }

		public int NUM { get; set; }
		public double START_POINT_OFFSET { get; set; }

		public double LAT { get; set; }
		public double LONG { get; set; }



		//  public double ALTITUDE { get; set; }

		public CarPositionData(int TRIP_ID, string JST, int CAR_NUM, string LINK_ID, int NUM, double START_POINT_OFFSET)
		{
			this.TRIP_ID = TRIP_ID;
			this.JST = JST;

			this.CAR_NUM = CAR_NUM;
			this.LINK_ID = LINK_ID;
			this.NUM = NUM;
			this.START_POINT_OFFSET = START_POINT_OFFSET;
			this.LAT = LAT;
			this.LONG = LONG;


		}
	}


	#region　前の時の緯度経度その他
	class RealCarPositionMatchingData

	{
		public int TRIP_ID { get; set; }
		public string JST { get; set; }
		public double LATITUDE { get; set; }
		public double LONGITUDE { get; set; }
		public string LINK_ID { get; set; }
		public int NUM { get; set; }
		public double START_POINT_OFFSET { get; set; }


		//  public double ALTITUDE { get; set; }



		public RealCarPositionMatchingData(int TRIP_ID, string JST, double LATITUDE, double LONGITUDE, string LINK_ID, int NUM, double START_POINT_OFFSET)
		{
			this.TRIP_ID = TRIP_ID;
			this.JST = JST;
			this.LATITUDE = LATITUDE;
			this.LONGITUDE = LONGITUDE;
			this.LINK_ID = LINK_ID;
			this.NUM = NUM;
			this.START_POINT_OFFSET = START_POINT_OFFSET;


		}
	}
	#endregion

	#region　新規緯度経度その他
	class VirtualCarPositionData

	{


		public double LATITUDE { get; set; }
		public double LONGITUDE { get; set; }
		public int NUM { get; set; }



		public VirtualCarPositionData(double LATITUDE, double LONGITUDE, int NUM)
		{

			this.LATITUDE = LATITUDE;
			this.LONGITUDE = LONGITUDE;
			this.NUM = NUM;


		}

	}
	#endregion
	class LinkListData
	{
		public int SEGMENT_ID { get; set; }
		public int SEMANTIC_LINK_ID { get; set; }
		public int LINK_NUMBER { get; set; }
		public string LINK_ID { get; set; }
		public LinkListData(int SEGMENT_ID, int SEMANTIC_LINK_ID, int LINK_NUMBER, string LINK_ID)
		{
			this.SEGMENT_ID = SEGMENT_ID;
			this.SEMANTIC_LINK_ID = SEMANTIC_LINK_ID;
			this.LINK_ID = LINK_ID;
			this.LINK_NUMBER = LINK_NUMBER;
		}
	}


	class Vector2D
	{
		public double x { get; set; }
		public double y { get; set; }

		public Vector2D(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		//点Pから線分ABへの最も近い点を探索する
		public static Vector2D nearest(Vector2D A, Vector2D B, Vector2D P)
		{
			Vector2D a = new Vector2D(B.x - A.x, B.y - A.y);
			Vector2D b = new Vector2D(P.x - A.x, P.y - A.y);
			double r = (a.x * b.x + a.y * b.y) / (a.x * a.x + a.y * a.y);

			if (r <= 0)
			{
				return A;
			}
			else if (r >= 1)
			{
				return B;
			}
			else
			{
				Vector2D result = new Vector2D(A.x + r * a.x, A.y + r * a.y);
				return result;
			}
		}

		//線分ABの長さ
		public static double distance(Vector2D A, Vector2D B)
		{
			return Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
		}

	}
}
	#endregion
