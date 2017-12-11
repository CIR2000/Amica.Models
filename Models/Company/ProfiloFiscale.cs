using Newtonsoft.Json;

namespace Amica.Models.Company
{
    public class ProfiloFiscale : ObservableObject
    {
        bool _professionista, _monomandatario;
        float _enasarco;
        public ProfiloFiscale()
        {
            RivalsaInps = new RivalsaInps();
            CassaAlboProfessionale = new CassaAlboProfessionale();
            Ritenuta = new Ritenuta();
        }
		public bool Professionista {
			set { SetProperty (ref _professionista, value); }
			get { return _professionista; } 
		}
		public bool Monomandatario {
			set { SetProperty (ref _monomandatario, value); }
			get { return _monomandatario; } 
		}
		public float Enasarco {
			set { SetProperty (ref _enasarco, value); }
			get { return _enasarco; } 
		}
        [JsonProperty("rivalsa_inps")]
        public RivalsaInps RivalsaInps { get; }
        [JsonProperty("cassa_albo_professionale")]
        public CassaAlboProfessionale CassaAlboProfessionale { get; }
        public Ritenuta Ritenuta { get; }
    }
}
