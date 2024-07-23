using System;
using System.Collections.Generic;


namespace GameArchitecture
{
    public class SceneConfigExample : SceneConfig
    {
        public override Dictionary<Type, Repository> CreatAllRepositories()
        {
            var repositoriesMap = new Dictionary<Type, Repository>();
            CreateRepository<BankRepository>(repositoriesMap);

            return repositoriesMap;
        }

        public override Dictionary<Type, Interactor> CreatAllInteractors()
        {
            var interactorsMap = new Dictionary<Type, Interactor>();
            CreateInteractor<BankInteractor>(interactorsMap);

            return interactorsMap;
        }


    }
}

