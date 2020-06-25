using System;
using System.Collections.Generic;
using System.Text;

namespace WrapperGenerator.Utilities
{
	public class ItemAddedEventArgs<T> : EventArgs
	{
		#region Fields
		private readonly T item;
		private readonly int index;
		#endregion

		#region Constructors
		public ItemAddedEventArgs (T item, int index)
		{
			this.item = item;
			this.index = index;
		}
		#endregion

		#region Properties
		public T Item
		{
			get
			{
				return this.item;
			}
		}

		public int Index
		{
			get
			{
				return this.index;
			}
		}
		#endregion
	}

	public class ItemRemovedEventArgs<T> : EventArgs
	{
		#region Fields
		private readonly T item;
		private readonly int index;
		#endregion

		#region Constructors
		public ItemRemovedEventArgs (T item, int index)
		{
			this.item = item;
			this.index = index;
		}
		#endregion

		#region Properties
		public T Item
		{
			get
			{
				return this.item;
			}
		}

		public int Index
		{
			get
			{
				return this.index;
			}
		}
		#endregion
	}

	public class ItemReplacedEventArgs<T> : EventArgs
	{
		#region Fields
		private readonly T oldItem;
		private readonly T newItem;
		private readonly int index;
		#endregion

		#region Constructors
		public ItemReplacedEventArgs (T oldItem, T newItem, int index)
		{
			this.oldItem = oldItem;
			this.newItem = newItem;
			this.index = index;
		}
		#endregion

		#region Properties
		public T OldItem
		{
			get
			{
				return this.oldItem;
			}
		}

		public T NewItem
		{
			get
			{
				return this.newItem;
			}
		}

		public int Index
		{
			get
			{
				return this.index;
			}
		}
		#endregion
	}
}
