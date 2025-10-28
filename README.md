# in-class-activities
## Devlogs
### W1
<b>In the Hierarchy, move the Camera off of the Cat GameObject, so that it’s no longer a child of the Cat. What happens when you run the game now, and why?</b>

The cat moves, but the camera stays still. Since the camera is no longer a 'child object' of the cat, so their positions are not connected.
<hr>

### W2
<b>1. Why are the `r`, `g`, and `b` variables `floats` instead of `ints`, `bools`, or `strings`?</b>
	a. `bool` and `string` don't really make sense. Maybe `int` would make sense, but the SpriteRenderer saves its RGB values as `floats`. Either way, RGB represents 'how red' or 'how green' or 'how blue', so we need a variable type that can represent a scale, which `bool` and `string` can't do.
	b. `bool` could work if you want it to be "YEAH IT'S RED" or "NO IT'S NOT RED"... I think that gives you like 8 possible color combinations.
<br><b>2. Why is the _bounce variable an int instead of a float, bool, or string?</b>
	a. Not `float` because can't have 0.5 of a bounce, although you could have `_bounces + 1.0f`? Not `bool` because we need to keep track of how *many* bounces. Not `string` because text isn't numbers, and you can't do numbers math with text. `int` makes the most sense.
<br><b>3. The error you got after Step X of Part 2 told you something useful about why that line of code was broken- what was it?</b>
	a. A lot of times for the "uncomment the right line of code" steps I would forget that I need an f for `float` variables, and I would get an error for some variable type called `double`, then I remembered float needs an "f".

<hr>

### W3
Table 6
1. You’re building a rhythm game, and you’re writing a method named `DidPlayerHitBeat` that tells you whether or not the player accurately hit a beat based on the time that they pressed a key. What would you make the parameters (input) and return type (output) of this method?
	- I would make the inputs a key press input, and the position of the beat. My tablemates and I discussed and some of us thought it should be what time the key was pressed instead of the position, but I think position would be easier to track, assuming this is the style of rhythm game where the beats move towards an endpoint. You could measure the distance of the beat from the endpoint, and if it's 'close enough', the player hit the beat.
	- For the output I would make it a `bool`. Since the method's name is *Did*PlayerHitBeat, and the only real way to answer a question 'Did XYZ...?' is a yes or no, meaning a boolean. 

2. With your table mates, come up with a metaphor to explain the relationship between classes and Components with a metaphor. Also describe how methods and member variables factor into that metaphor.  Remember that classes are templates that can become Components; member variables are traits of each class; and methods are things the class can do.
	 - A class is a baking recipe for a component, and the resultant cake is the Component. The ingredients that go into the 'cake' are like the member variables, and things you can do with the cake are the methods (eat, put in fridge, gift, deliver, etc...).

3. Why do you think the balls get extremely bright, especially in the Scene, if they bounce too many times?
	 - The balls are likely to get faster and faster as they bounce and move, so they will get brighter and brighter.
<hr>

### W4
Table 6<br>
Do your best to describe the following lines of code:

Tables 1-10: lines 5, 22, and 25<br>
5: `[SerializeField] private float _moveSpeed = 1.0f;`<br>
Declares a private float variable called `_moveSpeed` and gives it the value of 1.0f. [SerializeField] makes it visible in the editor.

22: `float translation = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;`<br>
Declares a float variable called `translation` and gives it a value that depends on user input, _moveSpeed, and deltaTime.

25: `transform.Translate(0, 0, translation);`<br>
Calls the Translate function on a transform Component, passing in 0, 0, and `translation`.


Table 6<br>
1. What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?<br>
We added Rigidbodies to Cat and Soccerball since they will be bouncing off of things (each other). We checked Is Trigger on the goal since the ball should be passing through the goal rather than bouncing off of it.

2. IF your game did not work perfectly the first time you tested it, talk about what you had to fix.<br>
We forgot to add the Rigidbody to Cat so the BounceOffWall script wasn't working and the ball was not moving when the cat appeared to touch it.

### W5
What if I try to GetComponent a component that the GameObject doesn't have?<br>
&emsp;&emsp;- GetComponent() returns null.

Plan for the Deer class<br>
It needs to be a MonoBehaviour class.<br>
Since we're going to use the NavMeshAgent, we need to GetComponent() that in.<br>
Since it needs a GameObject as a target, it needs a GameObject variable.<br>

Since we want the Deer to move towards its target, we need to give the NavMeshAgent a destination. If this target is stationary, it is enough to do this in Start(). We need to get the target's transform's position, and pass this in to NavMeshAgent.SetDestination().

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
