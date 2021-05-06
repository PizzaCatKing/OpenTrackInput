# OpenTrackInput
Simple Forms app that displays incoming data from opentrak's UDP over network output

How to use:
- Open this app
- Set port to something (i.e. 4747)
- Press start, the app will start listening to incoming UDP packets
- In open track set the Output to `UDP over netowork`
- Set the IP to the Address of the computer running OpenTrackInput, or 127.0.0.1 for localhost if running on the same computer
- Set the port to the same as above
- Set the input to the test tracker

![Open track's UDP over network settings dialog]./docs/look_it_totally_works_I_swear.PNG "Open track's UDP over network settings dialog")

- Start tracking in open track

- The values should start updating in real time (x, y, and z aren't updated by the test tracker)
![Open track and OpenTrackInput working together]./docs/look_it_totally_works_I_swear.PNG "Proof that the app totally works and I am not just making it up")