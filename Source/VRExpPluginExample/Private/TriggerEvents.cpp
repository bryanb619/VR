// Fill out your copyright notice in the Description page of Project Settings.


#include "TriggerEvents.h"

// Sets default values
ATriggerEvents::ATriggerEvents()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ATriggerEvents::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ATriggerEvents::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

