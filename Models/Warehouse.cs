namespace Amica.Models
{
    public class Warehouse : BaseModelWithCompanyId
    {
        private string _name;

        public string Name
        {
            set { SetProperty(ref _name, value); }
            get { return _name; }
        }
    }
}
