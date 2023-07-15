using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChatRedPacket.Bean
{
   public class RedPacket
    {
        public long Id { get; set; }
        public long sum { get; set; } 
        public long number { get; set; } 
        public long zero { get; set; }
        public long one { get; set; }
        public long two { get; set; }
        public long three { get; set; }
        public long four { get; set; }
        public long five { get; set; }
        public long six { get; set; }
        public long seven { get; set; }
        public long eight { get; set; }
        public long nine { get; set; }

        public override string ToString()
        {

            return $"金额 = {sum}, 包数量 = {number}, 0尾 = {zero}个,  1尾 = {zero}个, 2尾 = {two}个, 3尾 = {three}个, 4尾 = {four}个, 5尾 = {five}个, 6尾 = {six}个, 7尾 = {seven}个, 8尾 = {eight}个, 9尾 = {nine}个";
        }
    }
}
