namespace Amica.Models.Company
{
    public class CassaAlboProfessionale : ObservableObject
    {
        float _rate;
        string _description;
		public float Rate {
			set { SetProperty (ref _rate, value); }
			get { return _rate; } 
		}
		public string Description {
			set { SetProperty (ref _description, value); }
			get { return _description; } 
		}

    }
}
