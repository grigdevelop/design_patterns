GoF Definition
Ensure a class has only one instance, and provide a global point of access to it.

Concept
A particular class should have only one instance. You can use this instance whenever
you need it and therefore avoid creating unnecessary objects.

Real-Life Example
Suppose you are a member of a sports team and your team is participating in a
tournament. When your team plays against another team, as per the rules of the game,
the captains of the two sides must have a coin toss. If your team does not have a captain,
you need to elect someone to be the captain first. Your team must have one and only one
captain.

Illustration
These are the key characteristics in the following implementation:
• The constructor is private in this example. So, you cannot instantiate
in a normal fashion (using new).
• Before you attempt to create an instance of a class, you check whether
you already have an available copy. If you do not have any such copy,
you create it; otherwise, you simply reuse the existing copy.