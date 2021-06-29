using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol
{
    public class Pl
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Repost
    {
        public string pId { get; set; }
        public string uId { get; set; }
        public string uNm { get; set; }
    }

    public class MusicApi
    {
        public string _id { get; set; }
        public string uId { get; set; }
        public string uNm { get; set; }
        public string text { get; set; }
        public Pl pl { get; set; }
        public string name { get; set; }
        public string eId { get; set; }
        public string ctx { get; set; }
        public string img { get; set; }
        public IList<object> lov { get; set; }
        public Repost repost { get; set; }
        public int? nbR { get; set; }
        public int? nbP { get; set; }
    }
}
