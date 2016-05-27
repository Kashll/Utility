using System.Collections.Generic;
using System.ComponentModel;

namespace Utility
{
	public abstract class NotifyPropertyChangedImpl : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged
		{
			add { m_propertyChangedEventHandler += value; }
			remove { m_propertyChangedEventHandler -= value; }
		}

		protected void RaisePropertyChanged(params string[] propertyNames)
		{
			foreach (string propertyName in propertyNames)
				RaisePropertyChanged(propertyName);
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = m_propertyChangedEventHandler;
			OnPropertyChanged(propertyName);

		    handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		protected bool SetPropertyAndField<T>(string propertyName, T value, ref T field)
		{
			if (EqualityComparer<T>.Default.Equals(value, field))
				return false;

			field = value;
			RaisePropertyChanged(propertyName);
			return true;
		}

		PropertyChangedEventHandler m_propertyChangedEventHandler;
	}
}
