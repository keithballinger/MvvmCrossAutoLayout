using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.UI;

namespace MvvmCrossAutoLayout.ViewModels
{
	public class TicketViewModel 
		: MvxViewModel
	{
		public MvxCommand<string> TestCommand { 
			get { return new MvxCommand<string> (Test); } 
		}

		private bool _Telstra = true;

		public bool Telstra {
			get { return _Telstra; }
			set { RaisePropertyChanged (() => Telstra); }
		}

		private string _PremisesTabBackgroundColor = "#00FFFF";

		public string PremisesTabBackgroundColor {
			get { return _PremisesTabBackgroundColor; }
			set { RaisePropertyChanged (() => PremisesTabBackgroundColor); }
		}

		private string _PremisesTabTextColor = "#E5E5E5";

		public string PremisesTabTextColor {
			get { return _PremisesTabTextColor; }
			set { RaisePropertyChanged (() => PremisesTabTextColor); }
		}

		private MvxColor _BackgroundColor = MvxColors.Cornsilk;

		public MvxColor BackgroundColor {
			get { return _BackgroundColor; }
			set { RaisePropertyChanged (() => BackgroundColor); }
		}

		private MvxColor _TextColor = MvxColors.Cyan;

		public MvxColor TextColor {
			get { return _TextColor; }
			set { RaisePropertyChanged (() => TextColor); }
		}


		private string _hello = "Hello Tocklet";

		public string Hello { 
			get { return _hello; }
			set {
				_hello = value;
				RaisePropertyChanged (() => Hello);
			}
		}

		public void Test (string commandParameter)
		{
			_hello = commandParameter;
			_Telstra = !Telstra;
			_PremisesTabBackgroundColor = "#FF0000";
			_PremisesTabTextColor = "#FF00FF";
			RaiseAllPropertiesChanged ();
		}
	}
}
