GoF Definition
Specify the kinds of objects to create using a prototypical instance, and create new
objects by copying this prototype.

Concept
This pattern provides an alternative method for instantiating new objects by copying or
cloning an instance of an existing object. You can avoid the expense of creating a new
instance using this concept.

Real-Life Example
Suppose you have a master copy of a valuable document. You need to incorporate some
change into it to analyze the effect of the change. In this case, you can make a photocopy
of the original document and edit the changes in the photocopied document.

Computer World Example
Let’s assume that you already have an application that is stable. In the future, you may
want to modify the application with some small changes. You must start with a copy of
your original application, make the changes, and then analyze further. Surely you do not
want to start from scratch to merely make a change; this would cost you time and money.

