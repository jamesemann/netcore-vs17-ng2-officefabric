declare var fabric: any;

import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<button class="ms-Button">
          <span class="ms-Button-label">Create Account</span>
      </button>`,
})


export class AppComponent {
 name = 'Angular';

  ngAfterViewInit() {
    var ButtonElements = document.querySelectorAll(".ms-Button");
    for(var i = 0; i < ButtonElements.length; i++) {
      new fabric["Button"](ButtonElements[i], function() {
        alert("You clicked a New User button");
      });
    }
  }
}

//export class AppComponent  { name = 'Angular'; }
