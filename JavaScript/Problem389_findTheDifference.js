var Problem389_findTheDifference = {
	findTheDifference: function(s, t) {
		var letters = "abcdefghijklmnopqrstuvwxyz".split("");
		var sConcatT = s.concat(t);
		var nums = [];
		
		for (var i = 0; i < sConcatT.length; i++) {
			nums[i] = sConcatT.indexOf(sConcatT.charAt(i));
		}
		var extraLetter = 0;
		
		for (var j = 0; j < nums.length; j++) {
			extraLetter ^= nums[j];
		}
		return letters[extraLetter];
	}
};
console.log(Problem389_findTheDifference.findTheDifference("pigrwnnjblldbkzsyzpqibilzxriuzaflrzasjzamkgyaxhvffpkjwjghirepazxydqhjomifihqmpptwtgagecymzfncryltypnvlfjgjcaccealxkywptrucupxjdnysmpczuvlrpymzglxomadpiprbbflphjzvalqgtvknsyrfrvnbfcwgstwlftneejxegjwgxbhhuwxdtfgvtfbeabpaoumsevinvwpuqqngmdopqnnoblwoxtjsonhmanxnnkfxtxdbfwyrpmhefyktzogikaravunsqldwhcixhmbmqbxilbtqneawgciyvehucingsekqtrjhllalxolfyzohmdppdxbuttuxzfmxivxozjhurbswkilqsylmbdqgziwgtwjanraopyyjjdbddgsrhbimmvngvdnsmwbquitvhqslmfnftchsxilgjekdzcgheooafsmigywvhwrjqhzebqgldfmffdmrbwowiizzsaqpjuqx",
"hrejueshnvnjrsymbovlofxhzglbkotbyohcimezjldpvnqzlidxziyivwcltujnkuldajvjcznriblhmiorwzrlwmfcqltebndzqqpjyhcbpsrbstxtflwvjhggpixagngmzihgwrtenfgmkksqnubpmdayrgsqaxprhzpozkqimrixvqfmxbrqcpfxsldnfgnzfaqgelhhbnbgwiitrepldomgplhlxkoilsjokvjlhpvfbwvatqakvbwcfawhywmatrbvismuwqmoxahcchgaiwgfvdiyadyooaazpjxpcnnlicetxbpoodyfgpubgfntxtlrpydzxbmadytnznqguoyyqentwmaemetmkdjjbbijypsgfwafwxrfiiuwcuzpmwefyszejjfqdfpghnpujalfrihsbqsviqpktsdnusyudgxsgvxqnurtghgmrhzmzemlyfxbgefznxjwkgajcjtxnamvtmlzupwfixlywadqdwlhsbx"));