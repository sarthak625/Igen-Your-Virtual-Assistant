# Igen-Your-Virtual-Assistant
A speech recognition application that can interact with the user, set voice and text reminders and make calls to Google and Wolfram APIs

The features of this application are divided into three parts:
1> Using System.Speech to recognize a set of grammar and respond accordingly. =>
   Here there are added features such as lock the screen,shut down, sleep, smart replies, basic interactions
   
2> Text and Record Reminders =>
   Text reminders are normal reminders that will play after a certain time interval. 
   User can also record their voice and the same will be played after the time interval.
   This involved use of open source project NAudio to create and play wav files.
   
3> Google Engine =>
   User's voice is stored in a flac file and then send to Google.Cloud.Speech API. The text transcript is then looked up on
   google. If the text transcript starts with the keyword "answer" the application makes a call to wolfram alpha and gets the
   answer of that query enabling Igen to answer questions such as "Who is the prime minister of India?",etc. Though this
   is limited to 50 queries per day as Google API starts charging after this.
   
