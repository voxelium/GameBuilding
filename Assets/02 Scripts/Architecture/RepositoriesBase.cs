using System;
using System.Collections.Generic;

namespace GameArchitecture
{
    public class RepositoriesBase
    {
        private Dictionary<Type, Repository> repositoriesMap;

        public RepositoriesBase()
        {
            repositoriesMap = new Dictionary<Type, Repository>();
        }

        public void CreateAllRepositories()
        {
            CreateRepository<BankRepository>();
        }


        private void CreateRepository<T>() where T : Repository, new()
        {
            var repository = new T();
            var type = typeof(T);
            repositoriesMap[type] = repository;
        }


        public void SendOnCreateAllRepositories()
        {
            foreach (var repository in repositoriesMap.Values)
            {
                repository.OnCreate();
            }
        }

        public void InitializeAllRepositories()
        {
            foreach (var repository in repositoriesMap.Values)
            {
                repository.Initialize();
            }
        }

        public void StartAllRepositories()
        {
            foreach (var repository in repositoriesMap.Values)
            {
                repository.OnStart();
            }
        }

        public T GetRepository<T>() where T : Repository
        {
            var type = typeof(T);
            return (T)repositoriesMap[type];
        }

    }

}
