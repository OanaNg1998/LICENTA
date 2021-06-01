import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScheduleclassmodalComponent } from './scheduleclassmodal.component';

describe('ScheduleclassmodalComponent', () => {
  let component: ScheduleclassmodalComponent;
  let fixture: ComponentFixture<ScheduleclassmodalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ScheduleclassmodalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ScheduleclassmodalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
