using System.Collections;
using UnityEngine;

namespace GameArchitecture
{
    public class ArchTester : MonoBehaviour
    {
        public static Scene scene;

        private void Start()
        {
            var sceneConfig = new SceneConfigExample();
            scene = new Scene(sceneConfig);

            StartCoroutine(scene.InitializeRoutine());
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

}
