mergeInto(LibraryManager.library, {
  
 
  LastValue :function(lastvalue){
    var text = document.getElementById("Type");
    text.value = UTF8ToString(lastvalue);
  },
  
  Hello: function () {
    if (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)){

      var text = document.getElementById("Type");
     
      text.style.display = "block";
      text.focus();
      var returnStr = text.value;
      var bufferSize = lengthBytesUTF8(returnStr) + 1;
      var buffer = _malloc(bufferSize);
      stringToUTF8(returnStr, buffer, bufferSize);
      return buffer;
    }
  },



  Blur:function(){
    if (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)){

      var text = document.getElementById("Type");
      text.value = "";
      text.style.display = "none";
      text.blur();
    }
  },
  Check:function() {
    if (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)){
      return true;



    }
    else{
      return false;
    }

    
  }

  
      
  
}


);