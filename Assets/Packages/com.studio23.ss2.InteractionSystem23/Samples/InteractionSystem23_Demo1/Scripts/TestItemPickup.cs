using System.Threading;
using com.studio23.ss2.InteractionSystem23.Abstract;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace com.studio23.ss2.InteractionSystem23.Samples.Demo1
{
    public class TestItemPickup:ItemPickupBase
    {
        [SerializeField] private bool _canBeInterrupted = false;
        [SerializeField] private string _pickUpName = "Shinpachi's shinpachis";

        public override bool CanBeInterrupted => _canBeInterrupted;
     
        public override string PickUpName => _pickUpName;

        protected override void Initialize()
        {
            
        }

        protected override void HandleInteractionInitialize()
        {
            
        }

        protected override void HandleInteractionPause()
        {
            
        }

        protected override void HandleInteractionResumed()
        {
            
        }

        public override void AddPickupToInventory()
        {
            base.AddPickupToInventory();
            TestInventory.Instance.AddItem(this.PickUpName);
        }

        public override async UniTask DoInteraction(CancellationToken token)
        {
            AddPickupToInventory();
            
            await UniTask.Yield();  
        }
    }
}