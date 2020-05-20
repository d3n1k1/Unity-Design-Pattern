//-------------------------------------------------------------------------------------
//	AdapterPatternExample2.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

namespace AdapterPatternExample2
{
    public class AdapterPatternExample2 : MonoBehaviour
    {
        void Start()
        {
            // そのままEnemyRobotをnewした場合
            EnemyRobot fredTheRobot = new EnemyRobot();
            IEnemyAttacker tank = new EnemyTank();
            // アダプターパターンを利用した場合
            IEnemyAttacker adapter = new EnemyRobotAdapter(fredTheRobot);

            Debug.Log("--------fredTheRobot--------");
            fredTheRobot.ReactToHuman("Hans");
            fredTheRobot.WalkForward();

            Debug.Log("--------tank--------");
            tank.AssignDriver("Frank");
            tank.DriveForward();
            tank.FireWeapon();

            Debug.Log("--------adapter--------");
            adapter.AssignDriver("Mark");
            adapter.DriveForward();
            adapter.FireWeapon();
        }
    }

    public interface IEnemyAttacker
    {
        void FireWeapon();
        void DriveForward();
        void AssignDriver(string driver);
    }

    public class EnemyTank : IEnemyAttacker
    {
        public void FireWeapon()
        {
            int attackDamage = Random.Range(1, 10);
            Debug.Log("Enemy Tank does " + attackDamage + " damage");
        }

        public void DriveForward()
        {
            int movement = Random.Range(1, 5);
            Debug.Log("Enemy Tank moves " + movement + " spaces");
        }

        public void AssignDriver(string driver)
        {
            Debug.Log(driver + " is driving the tank");
        }
    }

    // Adaptee:
    public class EnemyRobot
    {
        public void SmashWithHands()
        {
            int attackDamage = Random.Range(1, 10);
            Debug.Log("Robot causes " + attackDamage + " damage with it hands");
        }

        public void WalkForward()
        {
            int movement = Random.Range(1, 3);
            Debug.Log("Robot walks " + movement + " spaces");
        }

        public void ReactToHuman(string driverName)
        {
            Debug.Log("Robot tramps on " + driverName);
        }
    }


    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot robot;

        public EnemyRobotAdapter(EnemyRobot robot)
        {
            this.robot = robot;
        }

        public void FireWeapon()
        {
            robot.SmashWithHands();
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void AssignDriver(string driver)
        {
            robot.ReactToHuman(driver);
        }
    }
}
