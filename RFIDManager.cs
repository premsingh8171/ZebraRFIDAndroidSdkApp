//using Com.Zebra.Rfid.Api3;
//using System;


//namespace ZebraRFIDAndroidSdkApp
//{
//    public class RFIDManager
//    {
//        private RFIDReader? _rfidReader;

//        // Initialize the RFID reader
//        public void InitializeRFIDReader()
//        {
//            try
//            {
//                _rfidReader = new RFIDReader(); // Initialize RFID reader (replace with actual constructor)

//                // Configure reader settings, such as connection parameters, read power, etc.
//                _rfidReader.Connect(); // Establish a connection to the RFID reader
//                _rfidReader.Events.OnTagRead += OnTagRead; // Subscribe to the tag read event
//            }
//            catch (Exception ex)
//            {
//                // Handle initialization error
//                Console.WriteLine($"Error initializing RFID reader: {ex.Message}");
//            }
//        }

//        // Event handler for when a tag is read
//        private void OnTagRead(object sender, RFIDTagEventArgs e)
//        {
//            // Handle the scanned RFID tag data
//            string scannedData = e.TagData; // Replace with the actual property to retrieve tag data
//            Console.WriteLine($"RFID Tag Scanned: {scannedData}");
//        }

//        // Start reading RFID tags
//        public void StartReading()
//        {
//            try
//            {
//                _rfidReader.StartReading(); // Begin reading RFID tags
//            }
//            catch (Exception ex)
//            {
//                // Handle start reading error
//                Console.WriteLine($"Error starting RFID reader: {ex.Message}");
//            }
//        }

//        // Stop reading RFID tags
//        public void StopReading()
//        {
//            try
//            {
//                _rfidReader.StopReading(); // Stop reading RFID tags
//            }
//            catch (Exception ex)
//            {
//                // Handle stop reading error
//                Console.WriteLine($"Error stopping RFID reader: {ex.Message}");
//            }
//        }

//        // Clean up resources when done
//        public void Dispose()
//        {
//            _rfidReader?.Dispose(); // Dispose of RFID reader resources
//        }
//    }
//}
