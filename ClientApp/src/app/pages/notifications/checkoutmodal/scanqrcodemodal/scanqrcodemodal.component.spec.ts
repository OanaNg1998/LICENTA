import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScanqrcodemodalComponent } from './scanqrcodemodal.component';

describe('ScanqrcodemodalComponent', () => {
  let component: ScanqrcodemodalComponent;
  let fixture: ComponentFixture<ScanqrcodemodalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ScanqrcodemodalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ScanqrcodemodalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
