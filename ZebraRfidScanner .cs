namespace ZebraRFIDAndroidSdkApp
{
    public class ZebraRfidScanner : IDisposable
    {
        // Event to notify when RFID data is received
        public event Action<string> OnDataReceived;

        // Initialize and start the RFID scanner
        public void StartScanning()
        {
            // Implement code to start scanning using Zebra RFID SDK
            // Subscribe to events or use other mechanisms to receive data
        }

        // Stop the RFID scanner
        public void StopScanning()
        {
            // Implement code to stop scanning using Zebra RFID SDK
        }

        // Clean up resources
        public void Dispose()
        {
            // Implement code to release resources and unregister event handlers
        }

        // Method to be called when RFID data is received
        private void NotifyDataReceived(string data)
        {
            OnDataReceived?.Invoke(data);
        }
    }
}
