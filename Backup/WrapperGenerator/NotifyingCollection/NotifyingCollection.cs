using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WrapperGenerator.Utilities
{
	public class NotifyingCollection<T> : Collection<T>
	{
		#region Constructors
		public NotifyingCollection () : base ()
		{
		}
		#endregion

		#region Events
		public event EventHandler<ItemAddedEventArgs<T>> ItemAdded;
		public event EventHandler<ItemRemovedEventArgs<T>> ItemRemoved;
		public event EventHandler<ItemReplacedEventArgs<T>> ItemReplaced;
		#endregion

		#region Protected Methods
		protected override void InsertItem (int index, T item)
		{
			base.InsertItem (index, item);
			this.RaiseItemAddedEvent (item, index);
		}

		protected override void RemoveItem (int index)
		{
			T item = this[index];
			base.RemoveItem (index);
			this.RaiseItemRemovedEvent (item, index);
		}

		protected override void SetItem (int index, T item)
		{
			T oldItem = this[index];
			base.SetItem (index, item);
			this.RaiseItemReplacedEvent (oldItem, item, index);
		}

		protected override void ClearItems ()
		{
			T[] items = new T[this.Count];
			this.CopyTo (items, 0);
			base.ClearItems ();

			for (int i = 0; i < items.Length; i++)
			{
				this.RaiseItemRemovedEvent (items[i], i);
			}
		}
		#endregion

		#region Private Methods

		/// <summary>       
		/// Raises the ItemAdded event.       
		/// </summary>       
		private void RaiseItemAddedEvent (T item, int index)
		{
			if (this.ItemAdded != null)
			{
				this.ItemAdded (this, new ItemAddedEventArgs<T> (item, index));
			}
		}

		/// <summary>       
		/// Raises the ItemRemoved event.       
		/// </summary>       
		private void RaiseItemRemovedEvent (T item, int index)
		{
			if (this.ItemRemoved != null)
			{
				this.ItemRemoved (this, new ItemRemovedEventArgs<T> (item, index));
			}
		}

		/// <summary>       
		/// Raises the ItemReplaced event.       
		/// </summary>       
		private void RaiseItemReplacedEvent (T oldItem, T newItem, int index)
		{
			if (this.ItemReplaced != null)
			{
				this.ItemReplaced (this, new ItemReplacedEventArgs<T> (oldItem, newItem, index));
			}
		}
		#endregion
	}
}
