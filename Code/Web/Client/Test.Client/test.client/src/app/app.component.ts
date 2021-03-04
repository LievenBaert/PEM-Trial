import { Component, OnInit } from '@angular/core';
import { TranslationService } from '@arcelormittal-platform/core';

@Component({
  selector: 'am-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'app';

  constructor(private translationService: TranslationService) {}

  ngOnInit() {
    this.translationService.setInitialLanguage();
  }
}
