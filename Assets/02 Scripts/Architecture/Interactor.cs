
namespace GameArchitecture
{
    public abstract class Interactor
    {
        public virtual void OnCreate() { } //когда все интеракторы созданы
        public virtual void Initialize() { } // когда все интеракторы выполнили OnCreate
        public virtual void OnStart() { } // когда все интеракторы инициализированы

    }

}
