# TjuvOchPolisProjekt
 IT-Högskolan Assignment !

Inlämnings Uppgift - 

You should create a city with three types of people: 
◦Citizens
◦Thief
◦Police

 ◦All persons have a number of properties: 
◦Where they are in the X and Y directions
◦Which direction is traveling, e.g.X direction = -1 and Y direction = 0
◦Inventory (List of items)

◦All these people move according to 6 different directions, which are decided randomly when the person is created: Left, right, oblique right or left, up or down. 

From time to time the people meet, and depending on who meets, different things happen:
1)police meet theif - The police catch the thief, and what he stole ends up in the police inventory
2)citizens meet theif - The burglar citizen on one of the things the citizen carries on himself. Theft Ports In The Thieves' Inventory.
3)Citizens meet police - Nothing happens

The city must be drawn in the Console, with the letters:
◦P for police
◦T for thief
◦M for citizens

As soon as a person disappears outside the city, he comes back at the other end, and continues his walk in the same direction as before.

As soon as something happens In the city, this should be printed out, eg "Thief robs citizens" or "Police take thief".

Inventory-Inventory list
◦ Every citizen has the following things with him:
◦ Keys
◦ Mobile phone
. Money
◦ Clock
◦ Every time a thief robs a citizen, he takes ONE random thing.
  The thing one ends up in the thief's inventory
◦ When the police catch the thief, the police take ALL things.

Other guidelines
 ◦Makes the city quite large, eg 100 x 25 “squares”.
◦ Create the characters either randomly, or you decide that there should be a certain number of each person type, such as 10 police officers, 20 thieves and 30 citizens. Work with the number to see how crime in the city changes.
◦ The program ska loopa automatically, as long as no person meets anyone else.
◦ When someone meets another person, the program should pause for a few seconds, and a text that tells what happened will be displayed.
◦Pause is achieved with the following code:
◦ At the top of the code you write: usingSystem.Threading;
◦ Where the break is to take place, write:
Thread.Sleep (2000); // Pause for 2000 milliseconds = 2 seconds.
◦ The following must be reported at the bottom of the program:
◦ Number of robbed citizens: 12
◦ Number of arrested thieves: 

Supplement to Assignment - Tjuv och police
◦ Our city gets a prison, where the thieves have to spend time thinking about their crimes.
◦ When the thief is caught by the police, he ends up in the Prison List. 
◦ There the thief gets brought for example 30 seconds, before the thief is free again.
◦ In our app it should be possible to see how many thieves are in prison, and how long everyone has been sitting there.
◦ Every time a thief is set free, it must be reported in the console.
