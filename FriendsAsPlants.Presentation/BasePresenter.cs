using System;

namespace FriendsAsPlants.Presentation
{
    public class BasePresenter
    {
        public virtual void OnAttached() { }
        public virtual void OnDetached() { }
        public virtual void OnVisible() { }
        public virtual void OnInvisible() { }
    }
}
