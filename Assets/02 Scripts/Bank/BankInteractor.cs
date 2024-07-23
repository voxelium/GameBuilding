
namespace GameArchitecture
{

    public class BankInteractor : Interactor
    {
        private BankRepository repository;
        public int coins => repository.coins;


        public override void OnCreate()
        {
            base.OnCreate();
            repository = ArchTester.scene.GetRepository<BankRepository>();
        }

        public override void Initialize()
        {
            Bank.Initialize(this);
        }

        public bool isEnoughCoins(int value)
        {
            return coins >= value;
        }

        public void AddCoins(object sender, int value)
        {
            repository.coins += value;
            repository.Save();
        }


        public void Spend(object sender, int value)
        {
            repository.coins -= value;
            repository.Save();
        }

    }
}

