
using System.Collections;

namespace GameArchitecture
{
    public class Scene
    {
        private InteractorsBase interactorsBase;
        private RepositoriesBase repositoriesBase;
        private SceneConfig sceneConfig;

        public Scene(SceneConfig config)
        {
            sceneConfig = config;
            repositoriesBase = new RepositoriesBase(config);
            interactorsBase = new InteractorsBase(config);
        }

        public IEnumerator InitializeRoutine()
        {
            repositoriesBase.CreateAllRepositories();
            interactorsBase.CreateAllIneractors();
            yield return null;

            repositoriesBase.SendOnCreateAllRepositories();
            interactorsBase.SendOnCreateAllInteractors();
            yield return null;

            repositoriesBase.InitializeAllRepositories();
            interactorsBase.InitializeAllInteractors();
            yield return null;

            repositoriesBase.StartAllRepositories();
            interactorsBase.StartAllInteractors();
            yield return null;
        }

        public T GetRepository<T>() where T : Repository
        {
            return repositoriesBase.GetRepository<T>();
        }

        public T GetInteractor<T>() where T : Interactor
        {
            return interactorsBase.GetInteractor<T>();
        }

    }
}

