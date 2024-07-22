
namespace GameArchitecture
{
    public abstract class Repository
    {
        public virtual void OnCreate() { } //когда все репозитории созданы
        public abstract void Initialize(); // когда все репозитории выполнили OnCreate
        public virtual void OnStart() { } // когда все репозитории инициализированы
        public abstract void Save();
    }
}

