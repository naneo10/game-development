
namespace _25._09._17
{
    /*
    [인터페이스 과제 1번]
    상호작용 오브젝트 만들기

    요구사항
    1.IInteractable 인터페이스를 만든다.
    -메서드: void Interact()
    2.다음 클래스를 만든다. (모두 IInteractbale 구현)
    -Chest -> Interact()에서 "상자를 열었다! 아이템 획득!" 출력
    -Door -> Interact()에서 "문을 열고 지나갔다!" 출력
    -Npc -> Interact()에서 "NPC와 대화를 시작했다!" 출력
    3.Main()에서 각 오프젝트의 객체를 생성하고, Interact() 메서드를 호출하여 상호작용을 출력한다.
    */ //과제

    /*
    상자를 열었다! 아이템 획득!
    문을 열고 지나갔다!
    NPC와 대화를 시작했다!
    */ //예시 출력

    interface IInteractable
    {
        void Interact();
    }

    class Chest : IInteractable
    {
        public void Interact()
        {
            Console.WriteLine("상자를 열었다! 아이템 획득!");
        }
    }

    class Door : IInteractable
    {
        public void Interact()
        {
            Console.WriteLine("문을 열고 지나갔다!");
        }
    }
    
    class NPC : IInteractable
    {
        public void Interact()
        {
            Console.WriteLine("NPC와 대화를 시작했다!");
        }
    }

    internal class AssignMent_03
    {
        static void Main()
        {
            Chest chest = new Chest();
            chest.Interact();

            Door door = new Door();
            door.Interact();

            NPC npc = new NPC();
            npc.Interact();
        }
    }
}
