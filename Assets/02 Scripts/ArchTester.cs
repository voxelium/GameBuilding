using System.Collections;
using GameArchitecture;
using UnityEngine;

public class ArchTester : MonoBehaviour
{
    public static RepositoriesBase repositoriesBase;
    public static InteractorsBase interactorsBase;

    void Start()
    {
        StartCoroutine(StartGameRoutine());
    }

    private IEnumerator StartGameRoutine()
    {
        repositoriesBase = new RepositoriesBase();
        interactorsBase = new InteractorsBase();
        yield return null;

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

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.A))
        {
            Bank.AddCoins(this, 5);
            Debug.Log("add coins 5 = " + Bank.coins);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Bank.Spend(this, 5);
            Debug.Log("spend coins 5 = " + Bank.coins);
        }
    }
}
