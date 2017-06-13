# Igen-Your-Virtual-Assistant
A speech recognition application that can interact with the user, set voice and text reminders and make calls to Google and Wolfram APIs

The features of this application are divided into three parts:

## Using System.Speech to recognize a set of grammar and respond accordingly
   Added features such as lock the screen,shut down, sleep, smart replies, basic interactions using speech
   
## Text and Record Reminders
   Text reminders are normal reminders that will play after a certain time interval. 
   Record reminders are voice recorded files that can play after a certain time interval.
   An open source project NAudio is used in this application to create and play wav files.
   
## Google Engine
   A recorded flac file is sent to Google.Cloud.Speech API. The text transcript returns an appropriate google search. 
   
## Installation
   To use navigate to bin/debug and open "IgenFinalVersion.exe". The full path to the destination is: 
   
   ```
   Igen-Your-Virtual-Assistant/bin/Debug/IgenFinalVersion.exe
   ```
