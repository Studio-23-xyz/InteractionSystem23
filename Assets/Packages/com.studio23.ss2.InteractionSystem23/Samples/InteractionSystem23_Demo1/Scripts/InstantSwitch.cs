using System.Threading;
using com.studio23.ss2.InteractionSystem23.Abstract;
using Cysharp.Threading.Tasks;

namespace com.studio23.ss2.InteractionSystem23.Samples.Demo1
{
    /// <summary>
    /// A basic switch that sends activation and deactivation events instantly
    /// </summary>
    public abstract class InstantSwitch : TogglableBase
    {
        
        protected override void HandleInteractionInitialize()
        {
            
        }

        protected override void HandleInteractionPause()
        {
            
        }

        protected override void HandleInteractionResumed()
        {
         
        }
        protected override void HandleInteractionCompleted()
        {
            
        }
        
        protected override async UniTask DoActivateInteraction(CancellationToken cancellationToken)
        {
            await UniTask.Yield(cancellationToken);
        }

        protected override async UniTask DoDeactivateInteraction(CancellationToken cancellationToken)
        {
            await UniTask.Yield(cancellationToken);
        }
    }
}