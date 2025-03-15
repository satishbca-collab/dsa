function pal(str, l, r){
    if(l >=r){
      return true;
    }
    
    if(str[l] == str[r]){
      return pal(str,l+1,r-1);
    }
    return false;
  }
  
  pal('dabbad',0,5);