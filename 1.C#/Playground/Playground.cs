string s1 = "flskd",s2 = "kfds;";


if (s1.Length > s2.Length)
    (s1, s2) = (s2, s1);

var arr1 = s1.Split(' ');
var arr2 = s2.Split(' ');

int i = 0;
int j = 1;

while (i < j) {
    if (arr1[i] != arr2[i] || arr1[^j] != arr2[^j])
        return false; 

    i++;
    j--;
}

return true; 



