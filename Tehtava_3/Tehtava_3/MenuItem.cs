using System;
namespace Tehtava_3
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public event System.EventHandler<MenuItemEventArgs> ItemSelected;

        public void Select()
        {
            ItemSelected(this, new MenuItemEventArgs { ItemId = Id });
        }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
