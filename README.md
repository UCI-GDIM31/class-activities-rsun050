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
	a. A lot of times for the "uncomment the right line of code" steps I would forget that I need an f for `float` variables, and I would get an error for some variable type called `double`.

<hr>

### W3
<hr>

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
