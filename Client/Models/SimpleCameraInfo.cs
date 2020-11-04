using VirtualStudio.Shared;

namespace VirtualStudio.Client
{
    public class SimpleCameraInfo : ClientInfo
    {
        public SimpleCameraInfo()
        {
            TransmissionMethods.Add(TransmissionMethodDescription.WebRtc);
            IODescription.Outputs.Add(EndpointDescription.CreateVideoEndpoint("Video"));
            IODescription.Outputs.Add(EndpointDescription.CreateAudioEndpoint("Audio"));
            IODescription.Inputs.Add(EndpointDescription.CreateVideoEndpoint("Feedback"));
        }
    }
}