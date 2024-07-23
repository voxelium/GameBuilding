
using System;
using System.Collections.Generic;

namespace GameArchitecture
{
    public abstract class SceneConfig
    {
        public abstract Dictionary<Type, Repository> CreatAllRepositories();
        public abstract Dictionary<Type, Interactor> CreatAllInteractors();

        public void CreateRepository<T>(Dictionary<Type, Repository> repositoriesMap) where T : Repository, new()
        {
            var repository = new T();
            var type = typeof(T);
            repositoriesMap[type] = repository;
        }

        public void CreateInteractor<T>(Dictionary<Type, Interactor> interactorsMap) where T : Interactor, new()
        {
            var interactor = new T();
            var type = typeof(T);
            interactorsMap[type] = interactor;
        }

    }
}

