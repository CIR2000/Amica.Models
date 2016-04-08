namespace Amica.vNext.Models.Documents
{
    public class DocumentNumber : ObservableObject
    {
		private string _numeric;
        private string _string;

		public string Numeric {
			set { SetProperty (ref _numeric, value); }
			get { return _numeric; }
		}

		public string String{
			set { SetProperty (ref _string, value); }
			get { return _string; }
		}

        public string Complete => (String == null) ? Numeric : $"{Numeric}/{String}";
    }
}