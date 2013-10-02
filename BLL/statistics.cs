using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
using System.Text;

namespace BLL
{
    public class statistics
    {
        private readonly DAL.tb_lxbx dal = new DAL.tb_lxbx();
        /// <summary>
        /// ������Դ���������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfYiXingChuanBoByDistrict(string district)
        {
            int num = 0;
            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11").Tables[0].Rows.Count;

            else if (district.Equals("�޺���"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

            else if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
            else if (district.Equals("��ɽ��"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
            else if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
            else if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
            else if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
            else if (district.Equals("��������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
            else if (district.Equals("ƺɽ����"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

            else
                num = -1;

            return num;
        }
        /// <summary>
        /// ���ͬ��/˫�Դ��� ������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfTongXingChuanBoByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// ���ע�䶾Ʒ	������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfZhuSheDuPinByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// ��ò�Ѫ������������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfCaiXueJiangByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// �����Ѫ/Ѫ��Ʒ ������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfShuXueByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// ���ĸӤ����	 ������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfMuYingChuanBoByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// ����Դ���+ע�䶾Ʒ	������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfXingChuanBoByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// ���ְҵ��¶	������
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfZhiYeBaoLuByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// �������	������	
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfQiTaByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// ��ò���	������		
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfBuXiangByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }

        /// <summary>
        /// ��úϼ�	������		
        /// <param name="district">����</param>
        /// </summary>
        public int GetNumOfHeJiByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx ").Tables[0].Rows.Count;

            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("��ɽ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("��������"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("ƺɽ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }




        /// <summary>
        /// ���HIV ������
        /// <param name="trans">����;��</param>
        /// </summary>
        public int GetNumOfHIVByTrans(string trans)
        {
            int num = 0;

            if (trans.Equals("ע�䶾Ʒ"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=21").Tables[0].Rows.Count;

            else
                if (trans.Equals("���Դ���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=11").Tables[0].Rows.Count;

                else if (trans.Equals("ͬ��/˫�Դ���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=12").Tables[0].Rows.Count;


                else if (trans.Equals("�ԽӴ�+ע�䶾Ʒ"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=22").Tables[0].Rows.Count;


                else if (trans.Equals("��Ѫ(��)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=23").Tables[0].Rows.Count;


                else if (trans.Equals("��Ѫ/Ѫ��Ʒ"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=24").Tables[0].Rows.Count;


                else if (trans.Equals("ĸӤ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=31").Tables[0].Rows.Count;


                else if (trans.Equals("ְҵ��¶"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=41").Tables[0].Rows.Count;


                else if (trans.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=51").Tables[0].Rows.Count;


                else if (trans.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=99").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }


        /// <summary>
        /// ���AIDS ������
        /// <param name="trans">����;��</param>
        /// </summary>
        public int GetNumOfAIDSByTrans(string trans)
        {
            int num = 0;

            if (trans.Equals("ע�䶾Ʒ"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=21").Tables[0].Rows.Count;

            else
                if (trans.Equals("���Դ���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=11").Tables[0].Rows.Count;

                else if (trans.Equals("ͬ��/˫�Դ���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=12").Tables[0].Rows.Count;


                else if (trans.Equals("�ԽӴ�+ע�䶾Ʒ"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=22").Tables[0].Rows.Count;


                else if (trans.Equals("��Ѫ(��)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=23").Tables[0].Rows.Count;


                else if (trans.Equals("��Ѫ/Ѫ��Ʒ"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=24").Tables[0].Rows.Count;


                else if (trans.Equals("ĸӤ����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=31").Tables[0].Rows.Count;


                else if (trans.Equals("ְҵ��¶"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=41").Tables[0].Rows.Count;


                else if (trans.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=51").Tables[0].Rows.Count;


                else if (trans.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=99").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }



        /// <summary>
        /// ���HIV ������(������Դ)
        /// <param name="trans">������Դ</param>
        /// </summary>
        public int GetNumOfHIVByYangBenLaiYuan(string source)
        {
            int num = 0;

            if (source.Equals("��ǰ���"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=11  and xz=1").Tables[0].Rows.Count;

            else
                if (source.Equals("��Ѫ(��Ʒ)ǰ���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=12  and xz=1").Tables[0].Rows.Count;

                else if (source.Equals("�Բ�����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=13  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("���������߼��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=14  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("��ǰ���(��������)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=15  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("�в��ڼ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=16  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("�����ѯ"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=17  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("��������ż���԰���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=18  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("Ů����������Ů���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=19  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("ְҵ��¶���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=20  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("���ֳ�����Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=21  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("�г���Ѫ(��)��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=22  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("�޳���Ѫ��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=23  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("���뾳��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=24  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("�±����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=25  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("ǿ��/�ͽ̽䶾��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=26  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("������/Ů���ս���Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=27  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("�����Ѻ��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=28  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("ר�����(��ע����Ⱥ)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=29  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=30  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=99  and xz=1").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }

        /// <summary>
        /// ���AIDS ������(������Դ)
        /// <param name="trans">������Դ</param>
        /// </summary>
        public int GetNumOfAIDSByYangBenLaiYuan(string source)
        {
            int num = 0;

            if (source.Equals("��ǰ���"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=11  and xz=2").Tables[0].Rows.Count;

            else
                if (source.Equals("��Ѫ(��Ʒ)ǰ���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=12  and xz=2").Tables[0].Rows.Count;

                else if (source.Equals("�Բ�����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=13  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("���������߼��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=14  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("��ǰ���(��������)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=15  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("�в��ڼ��"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=16  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("�����ѯ"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=17  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("��������ż���԰���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=18  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("Ů����������Ů���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=19  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("ְҵ��¶���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=20  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("���ֳ�����Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=21  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("�г���Ѫ(��)��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=22  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("�޳���Ѫ��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=23  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("���뾳��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=24  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("�±����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=25  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("ǿ��/�ͽ̽䶾��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=26  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("������/Ů���ս���Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=27  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("�����Ѻ��Ա���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=28  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("ר�����(��ע����Ⱥ)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=29  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=30  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("����"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=99  and xz=2").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }



        /// <summary>
        /// ���HIV ������(����ͳ��)
        /// <param name="trans">����</param>
        /// </summary>
        public int GetNumOfHIVByDistrict(string district)
        {
            int num = 0;
            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where xz=1").Tables[0].Rows.Count;
            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=1  and xz=1").Tables[0].Rows.Count;

                else
                    if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=2  and xz=1").Tables[0].Rows.Count;

                    else if (district.Equals("��ɽ��"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=3  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=4  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=5  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=6  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("��������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=7  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("ƺɽ����"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=8  and xz=1").Tables[0].Rows.Count;


                    else
                        num = -1;

            return num;
        }


        /// <summary>
        /// ���AIDS ������(����ͳ��)
        /// <param name="trans">����</param>
        /// </summary>
        public int GetNumOfAIDSByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("������"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where xz=2").Tables[0].Rows.Count;
            else
                if (district.Equals("�޺���"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=1  and xz=2").Tables[0].Rows.Count;

                else
                    if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=2  and xz=2").Tables[0].Rows.Count;

                    else if (district.Equals("��ɽ��"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=3  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=4  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=5  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=6  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("��������"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=7  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("ƺɽ����"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=8  and xz=2").Tables[0].Rows.Count;


                    else
                        num = -1;

            return num;
        }
    }

}
