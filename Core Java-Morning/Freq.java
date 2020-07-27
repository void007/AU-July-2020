
import java.util.*;
public class Freq {
    public static void main(String[] args) {
        String text=" How are you doing you are very brave";
        String a[]=text.split(" ");
        Map<String, Integer> mapStore=new HashMap<>();

        for (String str:a){
            if(mapStore.containsKey(str)){
                mapStore.put(str,1+mapStore.get(str));
            }
            else{
                mapStore.put(str,1);
            }
        }
        System.out.println(mapStore);
    }

}
