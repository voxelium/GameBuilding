using System;
using UnityEngine;

namespace GameArchitecture
{
    public static class Bank
    {
        public static int coins
        {
            get
            {
                CheckClass();
                return bankInteractor.coins;
            }
        }
        public static event Action OnBankInitializedEvent;

        public static bool isInitialized { get; private set; }
        private static BankInteractor bankInteractor;

        public static void Initialize(BankInteractor _bankInteractor)
        {
            bankInteractor = _bankInteractor;
            isInitialized = true;

            Debug.Log("Bank initialized: " + Bank.coins);
            OnBankInitializedEvent?.Invoke();
        }

        private static void CheckClass()
        {
            if (!isInitialized)
            {
                throw new System.Exception("Bank is not initialized");
            }
        }

        public static bool isEnoughCoins(int value)
        {
            CheckClass();
            return bankInteractor.isEnoughCoins(value);
        }

        public static void AddCoins(object sender, int value)
        {
            CheckClass();
            bankInteractor.AddCoins(sender, value);
        }


        public static void Spend(object sender, int value)
        {
            CheckClass();
            bankInteractor.Spend(sender, value);
        }
    }

}
