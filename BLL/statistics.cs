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
        /// 获得异性传播的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfYiXingChuanBoByDistrict(string district)
        {
            int num = 0;
            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11").Tables[0].Rows.Count;

            else if (district.Equals("罗湖区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

            else if (district.Equals("福田区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
            else if (district.Equals("南山区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
            else if (district.Equals("盐田区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
            else if (district.Equals("宝安区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
            else if (district.Equals("龙岗区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
            else if (district.Equals("光明新区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
            else if (district.Equals("坪山新区"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=11 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

            else
                num = -1;

            return num;
        }
        /// <summary>
        /// 获得同性/双性传播 的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfTongXingChuanBoByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=12 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得注射毒品	的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfZhuSheDuPinByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=21 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得采血（浆）的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfCaiXueJiangByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=23 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得输血/血制品 的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfShuXueByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=24 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得母婴传播	 的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfMuYingChuanBoByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=31 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得性传播+注射毒品	的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfXingChuanBoByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=22 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得职业暴露	的例数
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfZhiYeBaoLuByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=41 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得其他	的例数	
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfQiTaByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=51 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }
        /// <summary>
        /// 获得不详	的例数		
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfBuXiangByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where  dbo.tb_lxbx.grtj=99 and dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }

        /// <summary>
        /// 获得合计	的例数		
        /// <param name="district">地区</param>
        /// </summary>
        public int GetNumOfHeJiByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx ").Tables[0].Rows.Count;

            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=1").Tables[0].Rows.Count;

                else if (district.Equals("福田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=2").Tables[0].Rows.Count;
                else if (district.Equals("南山区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=3").Tables[0].Rows.Count;
                else if (district.Equals("盐田区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=4").Tables[0].Rows.Count;
                else if (district.Equals("宝安区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=5").Tables[0].Rows.Count;
                else if (district.Equals("龙岗区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=6").Tables[0].Rows.Count;
                else if (district.Equals("光明新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=7").Tables[0].Rows.Count;
                else if (district.Equals("坪山新区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where   dbo.tb_lxbx.xzqy=8").Tables[0].Rows.Count;

                else
                    num = -1;

            return num;
        }




        /// <summary>
        /// 获得HIV 的例数
        /// <param name="trans">传播途径</param>
        /// </summary>
        public int GetNumOfHIVByTrans(string trans)
        {
            int num = 0;

            if (trans.Equals("注射毒品"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=21").Tables[0].Rows.Count;

            else
                if (trans.Equals("异性传播"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=11").Tables[0].Rows.Count;

                else if (trans.Equals("同性/双性传播"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=12").Tables[0].Rows.Count;


                else if (trans.Equals("性接触+注射毒品"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=22").Tables[0].Rows.Count;


                else if (trans.Equals("采血(浆)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=23").Tables[0].Rows.Count;


                else if (trans.Equals("输血/血制品"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=24").Tables[0].Rows.Count;


                else if (trans.Equals("母婴传播"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=31").Tables[0].Rows.Count;


                else if (trans.Equals("职业暴露"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=41").Tables[0].Rows.Count;


                else if (trans.Equals("其他"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=51").Tables[0].Rows.Count;


                else if (trans.Equals("不详"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=1 and dbo.tb_lxbx.grtj=99").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }


        /// <summary>
        /// 获得AIDS 的例数
        /// <param name="trans">传播途径</param>
        /// </summary>
        public int GetNumOfAIDSByTrans(string trans)
        {
            int num = 0;

            if (trans.Equals("注射毒品"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=21").Tables[0].Rows.Count;

            else
                if (trans.Equals("异性传播"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=11").Tables[0].Rows.Count;

                else if (trans.Equals("同性/双性传播"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=12").Tables[0].Rows.Count;


                else if (trans.Equals("性接触+注射毒品"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=22").Tables[0].Rows.Count;


                else if (trans.Equals("采血(浆)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=23").Tables[0].Rows.Count;


                else if (trans.Equals("输血/血制品"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=24").Tables[0].Rows.Count;


                else if (trans.Equals("母婴传播"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=31").Tables[0].Rows.Count;


                else if (trans.Equals("职业暴露"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=41").Tables[0].Rows.Count;


                else if (trans.Equals("其他"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=51").Tables[0].Rows.Count;


                else if (trans.Equals("不详"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where dbo.tb_lxbx.xz=2 and dbo.tb_lxbx.grtj=99").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }



        /// <summary>
        /// 获得HIV 的例数(样本来源)
        /// <param name="trans">样本来源</param>
        /// </summary>
        public int GetNumOfHIVByYangBenLaiYuan(string source)
        {
            int num = 0;

            if (source.Equals("术前检查"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=11  and xz=1").Tables[0].Rows.Count;

            else
                if (source.Equals("受血(制品)前检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=12  and xz=1").Tables[0].Rows.Count;

                else if (source.Equals("性病门诊"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=13  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("其他就诊者检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=14  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("婚前检查(含涉外婚检)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=15  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("孕产期检查"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=16  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("检测咨询"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=17  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("阳性者配偶或性伴检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=18  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("女性阳性者子女检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=19  and xz=1").Tables[0].Rows.Count;


                else if (source.Equals("职业暴露检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=20  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("娱乐场所人员体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=21  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("有偿供血(浆)人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=22  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("无偿献血人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=23  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("出入境人员体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=24  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("新兵体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=25  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("强制/劳教戒毒人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=26  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("妇教所/女劳收教人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=27  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("其他羁押人员体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=28  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("专题调查(请注明人群)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=29  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("其他"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=30  and xz=1").Tables[0].Rows.Count;
                else if (source.Equals("不详"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=99  and xz=1").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }

        /// <summary>
        /// 获得AIDS 的例数(样本来源)
        /// <param name="trans">样本来源</param>
        /// </summary>
        public int GetNumOfAIDSByYangBenLaiYuan(string source)
        {
            int num = 0;

            if (source.Equals("术前检查"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=11  and xz=2").Tables[0].Rows.Count;

            else
                if (source.Equals("受血(制品)前检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=12  and xz=2").Tables[0].Rows.Count;

                else if (source.Equals("性病门诊"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=13  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("其他就诊者检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=14  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("婚前检查(含涉外婚检)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=15  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("孕产期检查"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=16  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("检测咨询"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=17  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("阳性者配偶或性伴检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=18  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("女性阳性者子女检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=19  and xz=2").Tables[0].Rows.Count;


                else if (source.Equals("职业暴露检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=20  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("娱乐场所人员体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=21  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("有偿供血(浆)人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=22  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("无偿献血人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=23  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("出入境人员体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=24  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("新兵体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=25  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("强制/劳教戒毒人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=26  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("妇教所/女劳收教人员检测"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=27  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("其他羁押人员体检"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=28  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("专题调查(请注明人群)"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=29  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("其他"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=30  and xz=2").Tables[0].Rows.Count;
                else if (source.Equals("不详"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where jcfl=99  and xz=2").Tables[0].Rows.Count;
                else
                    num = -1;

            return num;
        }



        /// <summary>
        /// 获得HIV 的例数(分区统计)
        /// <param name="trans">区域</param>
        /// </summary>
        public int GetNumOfHIVByDistrict(string district)
        {
            int num = 0;
            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where xz=1").Tables[0].Rows.Count;
            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=1  and xz=1").Tables[0].Rows.Count;

                else
                    if (district.Equals("福田区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=2  and xz=1").Tables[0].Rows.Count;

                    else if (district.Equals("南山区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=3  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("盐田区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=4  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("宝安区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=5  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("龙岗区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=6  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("光明新区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=7  and xz=1").Tables[0].Rows.Count;


                    else if (district.Equals("坪山新区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=8  and xz=1").Tables[0].Rows.Count;


                    else
                        num = -1;

            return num;
        }


        /// <summary>
        /// 获得AIDS 的例数(分区统计)
        /// <param name="trans">区域</param>
        /// </summary>
        public int GetNumOfAIDSByDistrict(string district)
        {
            int num = 0;

            if (district.Equals("深圳市"))

                num = dal.GetListBySql("select * from dbo.tb_lxbx where xz=2").Tables[0].Rows.Count;
            else
                if (district.Equals("罗湖区"))

                    num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=1  and xz=2").Tables[0].Rows.Count;

                else
                    if (district.Equals("福田区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=2  and xz=2").Tables[0].Rows.Count;

                    else if (district.Equals("南山区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=3  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("盐田区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=4  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("宝安区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=5  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("龙岗区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=6  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("光明新区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=7  and xz=2").Tables[0].Rows.Count;


                    else if (district.Equals("坪山新区"))

                        num = dal.GetListBySql("select * from dbo.tb_lxbx where xzqy=8  and xz=2").Tables[0].Rows.Count;


                    else
                        num = -1;

            return num;
        }
    }

}
