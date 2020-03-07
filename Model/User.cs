using System.ComponentModel.DataAnnotations;

namespace diving_api.Model
{
    public class User
    {
        private int _id;
        [Key]
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        public string guest_name{set;get;}
        public int rcode{set;get;}
    }
}