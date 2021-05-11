import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FindmeasuremodalComponent } from './findmeasuremodal.component';

describe('FindmeasuremodalComponent', () => {
  let component: FindmeasuremodalComponent;
  let fixture: ComponentFixture<FindmeasuremodalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FindmeasuremodalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FindmeasuremodalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
